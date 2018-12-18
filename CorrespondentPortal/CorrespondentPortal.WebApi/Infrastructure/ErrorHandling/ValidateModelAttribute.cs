using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CorrespondentPortal.WebApi.Infrastructure.ErrorHandling
{
    public class ValidateModelAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.ModelState.IsValid) return;
            var errorMessages = context.ModelState.SelectMany(entry => context.ModelState[entry.Key].Errors).Select(x => x.ErrorMessage);
            context.Result = new BadRequestObjectResult(errorMessages);
        }
    }
}
