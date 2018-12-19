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
    public class OrderHistoryController : Controller
    {
        private readonly IInfrastructureLogService _infrastructureLogService;
        private readonly IConfigurationService _configurationService;
        private readonly string _releaseName;

        public OrderHistoryController(IInfrastructureLogService infrastructureLogService, IConfigurationService configurationService)
        {
            _infrastructureLogService = infrastructureLogService;
            _configurationService = configurationService;
            _releaseName = _configurationService.ConfigurationSettings.ReleaseName;
        }

        [HttpGet]
        [Route("OrderHistory/")]
        [ApiExplorerSettings(IgnoreApi = true)]
        public async Task<IActionResult> Index()
        {
            var baseUrl = $"{Request.Scheme}://{Request.Host}{Request.PathBase}";
            ViewBag.PageTitle = "Order History";
            ViewBag.ReleaseName = _releaseName;

            return View("Index");
        }

        //[HttpGet]
        //[Route("[controller]/Init")]
        //public async Task<LoanSubmissionViewModel> Init()
        //{
            

        //    var model = new LoanSubmissionViewModel()
        //    {
        //        LoanProductOptions = GetLoanProductOptions(),
        //        LoanRateOptions = GetLoanRateOptions(),
        //        CraLoanOptions = GetCraLoanOptions()
        //    };

        //    return model;
        //}

    }
}