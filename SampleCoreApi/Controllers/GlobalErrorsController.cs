using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace SampleCoreApi.Controllers
{
    /// <summary>
    /// The GlobalErrorsController is decorated with [ApiExplorerSettings (IgnoreApi = true)]
    /// </summary>
    [Route("/errors")]
    [ApiController]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class GlobalErrorsController : ControllerBase
    {
        public IActionResult HandleError() 
        {
            // actual exception handling
            var context = HttpContext.Features.Get<IExceptionHandlerFeature>(); // Capture the exception
            var responseStatusCode = context.Error.GetType().Name switch
            {
                "Null Reference Exception" => HttpStatusCode.BadRequest,
                _ => HttpStatusCode.ServiceUnavailable
            };
            return Problem(detail: context.Error.Message , statusCode : (int)responseStatusCode);
        }
    }
}
