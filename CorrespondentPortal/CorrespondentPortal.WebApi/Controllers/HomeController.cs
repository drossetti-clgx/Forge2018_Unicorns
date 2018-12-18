using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using CorrespondentPortal.WebApi.Domain.Services.Configurations;
using CorrespondentPortal.WebApi.Domain.Services.InfrastructureLog;
using CorrespondentPortal.WebApi.DTO.DataTables;
using CorrespondentPortal.WebApi.Infrastructure.Configuration;
using CorrespondentPortal.WebApi.Infrastructure.HealthCheck;
using CorrespondentPortal.WebApi.Infrastructure.Security.Attributes;
using CorrespondentPortal.WebApi.ViewModels;

namespace CorrespondentPortal.WebApi.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHealthCheckUtility _healthCheckUtility;
        private readonly IInfrastructureLogService _infrastructureLogService;
        private readonly IConfigurationService _configurationService;
        private readonly string _releaseName;

        public HomeController(IHealthCheckUtility healthCheckUtility, IInfrastructureLogService infrastructureLogService, IConfigurationService configurationService)
        {
            _healthCheckUtility = healthCheckUtility;
            _infrastructureLogService = infrastructureLogService;
            _configurationService = configurationService;
            _releaseName = _configurationService.ConfigurationSettings.ReleaseName;
        }

        [HttpGet]
        [Route("/")]
        [ApiExplorerSettings(IgnoreApi = true)]
        public async Task<IActionResult> Index()
        {
            var baseUrl = $"{Request.Scheme}://{Request.Host}{Request.PathBase}";
            ViewBag.PageTitle = "Home";
            ViewBag.ReleaseName = _releaseName;

            return View("Dashboard", new HomeIndexViewModel()
            {
                BaseUrl = baseUrl,
                HealthCheckResponseDto = (await _healthCheckUtility.GetHealthCheckResultAsync()).ToDto()
        });
        }

        [HttpGet]
        [Route("[controller]/InfrastructureLogs")]
        [Authorize(Policy = "AdminLimitedAccessGroups")]
        [ApiExplorerSettings(IgnoreApi = true)]
        public IActionResult InfrastructureLogs()
        {
            var baseUrl = $"{Request.Scheme}://{Request.Host}{Request.PathBase}";
            ViewBag.PageTitle = "Infrastructure Logs";
            ViewBag.ReleaseName = _releaseName;

            return View("InfrastructureLogs", baseUrl);
        }

        [HttpGet]
        [Route("[controller]/Configurations")]
        [Authorize(Policy = "AdminLimitedAccessGroups")]
        [ApiExplorerSettings(IgnoreApi = true)]
        public IActionResult Configurations()
        {
            var baseUrl = $"{Request.Scheme}://{Request.Host}{Request.PathBase}";
            ViewBag.PageTitle = "Configurations";
            ViewBag.ReleaseName = _releaseName;

            return View("Configurations", new ConfigurationViewModel(_configurationService.GetConfigurations(), baseUrl));
        }

        [HttpGet]
        [ApiExplorerSettings(IgnoreApi = true)]
        [ApiUserAuthorize("AdminLimitedAccessGroups")]
        [Route("[controller]/SearchInfrastructureLogsDataTable")]
        public async Task<DataTablesResponseDto> SearchInfrastructureLogsDataTable()
        {
            var dataTablesRequestDto = new DataTablesRequestDto(Request.Query);

            var logResults = await _infrastructureLogService.SearchLogsAsync(dataTablesRequestDto.Start,
                dataTablesRequestDto.Length,
                dataTablesRequestDto.SearchValue,
                dataTablesRequestDto.SortDirection,
                dataTablesRequestDto.SortColumnName, dataTablesRequestDto.LogLevels).ConfigureAwait(false);

            var logResultDto = new DataTablesResponseDto
            {
                Draw = dataTablesRequestDto.Draw,
                RecordsTotal = logResults.TotalLogCount,
                RecordsFiltered = logResults.RecordsFiltered,
                Data = logResults.FilteredLogs.Select(x => x.ToDataTablesDto()).ToArray()
            };

            return logResultDto;
        }
    }
}