using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using Moq;
using CorrespondentPortal.WebApi.DAL.Repositories.Configuration;
using CorrespondentPortal.WebApi.Domain.Services.Configurations;
using CorrespondentPortal.WebApi.Infrastructure.Configuration;
using CorrespondentPortal.WebApi.Infrastructure.File.FileUtility;
using CorrespondentPortal.WebApi.Infrastructure.File.FileVault;
using CorrespondentPortal.WebApi.Infrastructure.HealthCheck;
using CorrespondentPortal.WebApi.Infrastructure.Http;
using CorrespondentPortal.WebApi.Infrastructure.Security.FncConnect;
using CorrespondentPortal.WebApi.Infrastructure.Security.JwtUtility;
using CorrespondentPortal.WebApi.Infrastructure.Shared;

namespace CorrespondentPortal.WebApi.Tests.Shared
{
    public static class TestHelper
    {
        private static readonly Random Random = new Random();

        public static IFileUtility GetFileVaultFileUtility()
        {
            return new FileUtility(new FileVaultGetFileBehavior(GetFncConnectJwtUtility(), GetHttpUtility(), GetConfigurationSettings()), new FileVaultStoreFileBehavior(GetFncConnectJwtUtility(), GetHttpUtility(), GetConfigurationSettings()), new FileVaultGetPublicUrlBehavior(GetFncConnectJwtUtility(), GetConfigurationSettings()));
        }

        public static IJwtUtility GetFncConnectJwtUtility()
        {
            return new JwtUtility(new FncConnectValidateJwtBehavior(GetHttpUtility(), GetConfigurationSettings()), new FncConnectGenerateJwtBehavior(GetHttpUtility(), GetConfigurationSettings()));
        }

        public static IHttpUtility GetHttpUtility()
        {
            return new HttpUtility();
        }

        public static TestServer GetTestServer()
        {
            var projectDir = System.IO.Directory.GetCurrentDirectory();
            var builder = new WebHostBuilder()
                .UseEnvironment("Development")
                .UseContentRoot(projectDir).UseConfiguration(new ConfigurationBuilder()
                    .SetBasePath(projectDir)
                    .AddJsonFile("appsettings.Development.json")
                    .Build()
                )
                .UseStartup<Startup>();
            return new TestServer(builder);
        }

        public static HttpContext CreateHttpContext(int clientId, IQueryCollection queryCollection = null)
        {
            return new DefaultHttpContext()
            {
                Items = new Dictionary<object, object>() { { "ClientId", clientId.ToString() } },
                Request =
                {
                    Query = queryCollection
                }
            };
        }

        public static string GenerateRandomString(int length, bool useAlphaUpper = true, bool useAlphaLower = true, bool useNumeric = true, bool useSpecialCharacters = false)
        {
            const string alphaLower = "abcdefghijklmnopqrstuvwxyz";
            const string alphaUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string specialCharacters = "/\\!@#$%^&*()-=+_{}[]|;':\"<>?/";
            const string numeric = "0123456789";

            var result = string.Empty;

            var searchString = (useAlphaLower ? alphaLower : "") + (useAlphaUpper ? alphaUpper : "") + (useNumeric ? numeric : "") + (useSpecialCharacters ? specialCharacters : "");

            if (length > 0 && searchString.Length > 0)
            {
                for (var i = 0; i < length; i++)
                {
                    result += searchString[Random.Next(searchString.Length)];
                }
            }

            return result;
        }

        public static List<IHealthCheckable> CreateHealthCheck(HealthStatus healthStatus = HealthStatus.Active)
        {
            var healthCheck1 = new HealthCheck("Test Health Check 1");
            healthCheck1.AddVital("Health Check 1 Vital 1", HealthStatus.Active);
            healthCheck1.AddVital("Health Check 1 Vital 2", healthStatus);

            var healthCheck2 = new HealthCheck("Test Health Check 2");
            healthCheck2.AddVital("Health Check 2 Vital 1", HealthStatus.Active);

            var mockHealthCheck1 = new Mock<IHealthCheckable>();
            mockHealthCheck1.Setup(x => x.GetHealthAsync()).Returns(Task.FromResult(healthCheck1));

            var mockHealthCheck2 = new Mock<IHealthCheckable>();
            mockHealthCheck2.Setup(x => x.GetHealthAsync()).Returns(Task.FromResult(healthCheck2));

            var list = new List<IHealthCheckable>()
            {
                mockHealthCheck1.Object,
                mockHealthCheck2.Object,
                mockHealthCheck2.Object
            };

            return list;
        }
        
        public static IConfigurationService GetConfigurationSettings(Dictionary<string, string> configurations = null, List<KeyValuePair<string, string>> appSettingsConfigs = null)
        {
            var defaultConfigruations = new Dictionary<string, string>()
            {
                {"FncConnectKey", "5Y1YOS2Y7KACO5CBUPCBZXV7A5UP0N72UV2Y875D" },
                {"FncConnectSecret", "YUOL3E70K2VL8F8143ABSVUJC3ZAJSZRBCI4N1G7" },
                {"FncConnectUrl", "https://dev.fncconnect.com/" },
                {"FncFileVaultUrl", "https://devbravo.fncinc.com/FileVault/" }
            };

            configurations = configurations ?? new Dictionary<string, string>();

            foreach (var entry in configurations)
            {
                if (defaultConfigruations.ContainsKey(entry.Key))
                {
                    defaultConfigruations[entry.Key] = entry.Value;
                }
                else
                {
                    defaultConfigruations.Add(entry.Key, entry.Value);
                }
            }

            appSettingsConfigs = appSettingsConfigs ?? new List<KeyValuePair<string, string>>();

            var configurationRoot = new ConfigurationBuilder().AddInMemoryCollection(appSettingsConfigs)
                .Build();

            var configurationRepositoryMock = new Mock<IConfigurationRepository>();
            configurationRepositoryMock.Setup(x => x.GetValueByKey(It.IsAny<string>())).Returns<string>(x => defaultConfigruations.ContainsKey(x) ? defaultConfigruations[x] : "");

            var configurationSettings = new ConfigurationSettings();
            configurationSettings.Load(configurationRepositoryMock.Object, configurationRoot);
            return new ConfigurationService(configurationRepositoryMock.Object, configurationRoot);
        }

        public static IJwtUtility GetFakeJwtUtility(string jwtToGenerate = "testJwt", int clientIdToReturn = 1)
        {
            var jwtUtilityMock = new Mock<IJwtUtility>();
            jwtUtilityMock.Setup(x => x.GenerateJwtAsync(It.IsAny<int>(), It.IsAny<IEnumerable<KeyValuePair<string, string>>>())).Returns(Task.FromResult(HttpFragileOperationResult<GenerateJwtResult>.CreateSuccessfulResult(new GenerateJwtResult(jwtToGenerate), HttpStatusCode.OK, "")));
            jwtUtilityMock.Setup(x => x.ValidateJwtAsync(It.IsAny<string>())).Returns(Task.FromResult(HttpFragileOperationResult<ValidateJwtResult>.CreateSuccessfulResult(new ValidateJwtResult(true, clientIdToReturn.ToString()), HttpStatusCode.OK, "")));
            return jwtUtilityMock.Object;
        }
    }
}
