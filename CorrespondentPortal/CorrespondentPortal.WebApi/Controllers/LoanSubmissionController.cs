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
using CorrespondentPortal.WebApi.DTO;
using System.Collections.Generic;

namespace CorrespondentPortal.WebApi.Controllers
{
    public class LoanSubmissionController : Controller
    {
        private readonly IInfrastructureLogService _infrastructureLogService;
        private readonly IConfigurationService _configurationService;
        private readonly string _releaseName;

        public LoanSubmissionController(IInfrastructureLogService infrastructureLogService, IConfigurationService configurationService)
        {
            _infrastructureLogService = infrastructureLogService;
            _configurationService = configurationService;
            _releaseName = _configurationService.ConfigurationSettings.ReleaseName;
        }

        [HttpGet]
        [Route("LoanSubmission/")]
        [ApiExplorerSettings(IgnoreApi = true)]
        public async Task<IActionResult> Index()
        {
            var baseUrl = $"{Request.Scheme}://{Request.Host}{Request.PathBase}";
            ViewBag.PageTitle = "Loan Submission";
            ViewBag.ReleaseName = _releaseName;

            return View("Index");
        }

        [HttpGet]
        [Route("[controller]/Init")]
        public async Task<LoanSubmissionViewModel> Init()
        {
            

            var model = new LoanSubmissionViewModel()
            {
                LoanProductOptions = GetLoanProductOptions(),
                LoanRateOptions = GetLoanRateOptions(),
                CraLoanOptions = GetCraLoanOptions()
            };

            return model;
        }

        private List<DropdownDto> GetCraLoanOptions()
        {
            var dropdownList = new List<DropdownDto>
            {
                new DropdownDto{ Description = "Yes", Value = "Yes" },
                new DropdownDto{ Description = "No", Value = "No" }
            };
            return dropdownList;
        }

        private List<DropdownDto> GetLoanProductOptions()
        {
            var dropdownList = new List<DropdownDto>
            {
                new DropdownDto{ Description = "30/15", Value = "30/15" }
            };
            return dropdownList;
        }

        private List<DropdownDto> GetLoanRateOptions()
        {
            var dropdownList = new List<DropdownDto>
            {
                new DropdownDto{ Description = "Fixed", Value = "Fixed" },
                new DropdownDto{ Description = "Adjustable", Value = "Adjustable" }
            };
            return dropdownList;
        }
        //[HttpGet]
        //[Route("[controller]/InfrastructureLogs")]
        //[Authorize(Policy = "AdminLimitedAccessGroups")]
        //[ApiExplorerSettings(IgnoreApi = true)]
        //public IActionResult InfrastructureLogs()
        //{
        //    var baseUrl = $"{Request.Scheme}://{Request.Host}{Request.PathBase}";
        //    ViewBag.PageTitle = "Infrastructure Logs";
        //    ViewBag.ReleaseName = _releaseName;

        //    return View("InfrastructureLogs", baseUrl);
        //}

        //[HttpGet]
        //[Route("[controller]/Configurations")]
        //[Authorize(Policy = "AdminLimitedAccessGroups")]
        //[ApiExplorerSettings(IgnoreApi = true)]
        //public IActionResult Configurations()
        //{
        //    var baseUrl = $"{Request.Scheme}://{Request.Host}{Request.PathBase}";
        //    ViewBag.PageTitle = "Configurations";
        //    ViewBag.ReleaseName = _releaseName;

        //    return View("Configurations", new ConfigurationViewModel(_configurationService.GetConfigurations(), baseUrl));
        //}

        //[HttpGet]
        //[ApiExplorerSettings(IgnoreApi = true)]
        //[ApiUserAuthorize("AdminLimitedAccessGroups")]
        //[Route("[controller]/SearchInfrastructureLogsDataTable")]
        //public async Task<DataTablesResponseDto> SearchInfrastructureLogsDataTable()
        //{
        //    var dataTablesRequestDto = new DataTablesRequestDto(Request.Query);

        //    var logResults = await _infrastructureLogService.SearchLogsAsync(dataTablesRequestDto.Start,
        //        dataTablesRequestDto.Length,
        //        dataTablesRequestDto.SearchValue,
        //        dataTablesRequestDto.SortDirection,
        //        dataTablesRequestDto.SortColumnName, dataTablesRequestDto.LogLevels).ConfigureAwait(false);

        //    var logResultDto = new DataTablesResponseDto
        //    {
        //        Draw = dataTablesRequestDto.Draw,
        //        RecordsTotal = logResults.TotalLogCount,
        //        RecordsFiltered = logResults.RecordsFiltered,
        //        Data = logResults.FilteredLogs.Select(x => x.ToDataTablesDto()).ToArray()
        //    };

        //    return logResultDto;
        //}
    }
}