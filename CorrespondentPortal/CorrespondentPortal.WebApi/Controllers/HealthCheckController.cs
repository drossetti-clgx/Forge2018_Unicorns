using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CorrespondentPortal.WebApi.DTO.HeathCheck;
using CorrespondentPortal.WebApi.Infrastructure.HealthCheck;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace CorrespondentPortal.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class HealthCheckController : Controller
    {
        private readonly IHealthCheckUtility _healthCheckUtility;
        public HealthCheckController(IHealthCheckUtility healthCheckUtility)
        {
            _healthCheckUtility = healthCheckUtility;
        }

        /// <summary>
        /// Get Health Check
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [SwaggerResponse((int)HttpStatusCode.OK, typeof(GetHealthCheckResponseDto))]
        public async Task<IActionResult> Get()
        {
            return Ok((await _healthCheckUtility.GetHealthCheckResultAsync().ConfigureAwait(false)).ToDto());
        }
    }
}
