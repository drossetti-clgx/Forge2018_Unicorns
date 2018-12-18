using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.PlatformAbstractions;
using Swashbuckle.AspNetCore.Swagger;
using System.IO;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.DataProtection;
using CorrespondentPortal.WebApi.Infrastructure.Configuration;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Hangfire;
using CorrespondentPortal.WebApi.DAL.Repositories.Client;
using CorrespondentPortal.WebApi.DAL.Repositories.Configuration;
using CorrespondentPortal.WebApi.DAL.Repositories.InfrastructureLog;
using CorrespondentPortal.WebApi.Infrastructure.File.FileUtility;
using CorrespondentPortal.WebApi.Infrastructure.File.FileVault;
using CorrespondentPortal.WebApi.Infrastructure.Hangfire;
using CorrespondentPortal.WebApi.Infrastructure.Http;
using CorrespondentPortal.WebApi.Infrastructure.Security.AuthorizationRequirements;
using CorrespondentPortal.WebApi.Infrastructure.Security.FncConnect;
using CorrespondentPortal.WebApi.Infrastructure.Security.JwtUtility;
using CorrespondentPortal.WebApi.Infrastructure.Security.Ldap;
using CorrespondentPortal.WebApi.Infrastructure.Security.User;
using CorrespondentPortal.WebApi.Domain.Services.Client;
using CorrespondentPortal.WebApi.Domain.Services.InfrastructureLog;
using CorrespondentPortal.WebApi.Infrastructure.HealthCheck;
using CorrespondentPortal.WebApi.Infrastructure.Notification;
using CorrespondentPortal.WebApi.Infrastructure.Security.Attributes;
using System;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.AzureAppServices.Internal;
using Microsoft.Extensions.Options;
using CorrespondentPortal.WebApi.Infrastructure.Logging;
using CorrespondentPortal.WebApi.Domain.Services.Configurations;

namespace CorrespondentPortal.WebApi
{
    [ExcludeFromCodeCoverage]
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<JwtAuthenticationAttribute>();

            services.AddDbContext<EFClientRepository>(options => options.UseSqlServer(Configuration.GetConnectionString("DatabaseConnection")));
            services.AddDbContext<EFInfrastructureLogRepository>(options => options.UseSqlServer(Configuration.GetConnectionString("DatabaseConnection")));
            services.AddDbContext<ConfigurationRepository>(options => options.UseSqlServer(Configuration.GetConnectionString("DatabaseConnection")));

            services.AddTransient<IConfigurationRepository, ConfigurationRepository>();
            services.AddTransient<IInfrastructureLogRepository, EFInfrastructureLogRepository>();
            services.AddTransient<IClientRepository, EFClientRepository>();

            services.AddTransient<IClientService, ClientService>();
            services.AddTransient<IInfrastructureLogService, InfrastructureLogService>();

            services.AddTransient<IConnectToGroupLdapBehavior, FncConnectToGroupLdapBehavior>();
            services.AddTransient<IConnectToAuthLdapBehavior, CoreLogicConnectToAuthLdapBehavior>();
            services.AddTransient<IGetLdapGroupsBehavior, GetLdapGroupsBehavior>();
            services.AddTransient<ILdapUtility, LdapUtility>();

            services.AddTransient<IGetAppUserBehavior, LdapGetAppUserBehavior>();
            services.AddTransient<IAppUserUtility, AppUserUtility>();

            services.AddTransient<IHealthCheckUtility, HealthCheckUtility>();
            services.AddSingleton<IHttpUtility, HttpUtility>();

            services.AddTransient<IGenerateJwtBehavior, FncConnectGenerateJwtBehavior>();
            services.AddTransient<IValidateJwtBehavior, FncConnectValidateJwtBehavior>();
            services.AddTransient<IJwtUtility, JwtUtility>();

            services.AddTransient<IGetFileBehavior, FileVaultGetFileBehavior>();
            services.AddTransient<IStoreFileBehavior, FileVaultStoreFileBehavior>();
            services.AddTransient<IGetPublicUrlBehavior, FileVaultGetPublicUrlBehavior>();
            services.AddTransient<IFileUtility, FileUtility>();

            services.AddTransient<IHealthCheckTranslationBehavior, HealthCheckToHtmlTranslatorBehavior>();
            services.AddTransient<INotificationBehavior, EmailNotificationBehavior>();
            services.AddTransient<IHealthCheckNotifierUtility, HealthCheckNotifierUtility>();

            services.AddTransient<HangfireHealthCheck>();

            services.AddTransient(x => new List<IHealthCheckable>
            {
                x.GetService<IJwtUtility>(),
                x.GetService<IFileUtility>(),
                x.GetService<ILdapUtility>(),
                x.GetService<HangfireHealthCheck>()
            });

            services.AddMvc();

            //Configurations
            services.AddTransient<IConfigurationService, ConfigurationService>();
            //services.AddSingleton<IConfigurationSettings>(new ConfigurationSettings());
            var serviceProvider = services.BuildServiceProvider();
            var configurationService = serviceProvider.GetService<IConfigurationService>();
            //configurationService.ConfigurationSettings.Load(serviceProvider.GetService<IConfigurationRepository>(), Configuration);
            
            //Logging
            services.AddLogging(builder => { builder.AddProvider(new InfrastructureLoggerProvider(builder.Services.BuildServiceProvider())); });

            //Authorization
            services.AddAuthorization(options =>
            {
                options.AddPolicy("AdminLimitedAccessGroups", policy =>
                {
                    policy.AddAuthenticationSchemes(CookieAuthenticationDefaults.AuthenticationScheme);
                    policy.AddRequirements(new UserInAtLeastOneGroupAuthorizationRequirement(configurationService.ConfigurationSettings.AdminLimitedAccessGroups));
                });
                options.AddPolicy("AdminAllAccessGroups", policy =>
                {
                    policy.AddAuthenticationSchemes(CookieAuthenticationDefaults.AuthenticationScheme);
                    policy.AddRequirements(new UserInAtLeastOneGroupAuthorizationRequirement(configurationService.ConfigurationSettings.AdminAllAccessGroups));
                });
            });

            //Hangfire
            services.AddHangfire(config => config.UseSqlServerStorage(Configuration.GetConnectionString("DatabaseConnection")));

            //Authentication
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
            {
                options.LoginPath = "/Account/SignIn";
                options.AccessDeniedPath = "/Account/Unauthorized";
            });

            if (configurationService.ConfigurationSettings.Environment != "LOCAL")
            {
                services.AddDataProtection()
                    .PersistKeysToFileSystem(new DirectoryInfo(configurationService.ConfigurationSettings.KeyStoreLocation))
                    .SetApplicationName("CorrespondentPortal");
            }

            // Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "CoreLogic CorrespondentPortal API",
                    Description = "Allows integration with the CoreLogic CorrespondentPortal. <br/><br/><br/><b>*</b>A 500 error may occur but is unexpected by the server and should be reported to the supporting development team.",
                });

                //Set the comments path for the swagger json and ui.
                var basePath = PlatformServices.Default.Application.ApplicationBasePath;
                var xmlPath = Path.Combine(basePath, "CorrespondentPortal.WebApi.xml");
                c.IncludeXmlComments(xmlPath);
                c.OperationFilter<SwaggerJwtAuthorizationOperationFilter>();
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IConfigurationService configurationService, IHealthCheckUtility healthCheckUtility)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseAuthentication();
            app.UseMvc();
            app.UseStaticFiles();
            app.UseHangfireServer();

            app.UseHangfireDashboard("/hangfire", new DashboardOptions
            {
                AppPath = "/CorrespondentPortal",
                Authorization = new[] { new HangfireDashboardAuthorizationFilter(configurationService.ConfigurationSettings.AdminAllAccessGroups) }
            });

            //Recurring Jobs
            var cronExpression = configurationService.ConfigurationSettings.HealthCheckNotificationCheckInterval;
            RecurringJob.AddOrUpdate("Check Health Status", () => healthCheckUtility.CheckHealthStatusAndNotifyAsync(), cronExpression);

            app.UseSwagger();
            app.UseSwaggerUI(config =>
            {
                config.SwaggerEndpoint("/CorrespondentPortal/swagger/v1/swagger.json",
                    "CoreLogic CorrespondentPortal API v1");
            });
        }
    }
}
