using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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
            return Problem("Something went wrong , Please contact administrator");
        }
    }
}
