using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.SwaggerGen;
using CorrespondentPortal.WebApi.Domain.Services.Client;
using CorrespondentPortal.WebApi.Domain.Services.InfrastructureLog;
using CorrespondentPortal.WebApi.Infrastructure.Security.Attributes;
using CorrespondentPortal.WebApi.Infrastructure.Shared;

namespace CorrespondentPortal.WebApi.Controllers
{
    public class InfrastructureLogsController : Controller
    {
        private readonly IInfrastructureLogService _infrastructureLogService;

        public InfrastructureLogsController(IInfrastructureLogService infrastructureLogService, IClientService clientService)
        {
            _infrastructureLogService = infrastructureLogService;
        }

        [HttpGet]
        [JwtAuthenticationServiceFilter]
        [SwaggerResponse((int)HttpStatusCode.Unauthorized)]
        [SwaggerResponse((int)HttpStatusCode.OK, typeof(InfrastructureLogServiceSearchResult))]
        [Route("api/InfrastructureLogs")]
        public async Task<IActionResult> SearchInfrastructureLogs(int start = 0, int length = 10, string searchValue = "", SortDirection sortDirection = SortDirection.Descending, InfrastructureLogSortColumnName sortColumnName = InfrastructureLogSortColumnName.CreatedDate, LogLevel[] logLevels = null)
        {
            return Ok(await _infrastructureLogService.SearchLogsAsync(start, length, searchValue, sortDirection, sortColumnName, logLevels).ConfigureAwait(false));
        }
    }
}
