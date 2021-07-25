using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("Test")]
        public clsResponse Test() 
        {
            var response = new clsResponse() { message = "", responsecode = 200 };
            return response;
        }
        
        [HttpPost("GetName")]
        public string GetName(string id)
        {
            int userid = Convert.ToInt32(id);
            return "deepak porwal";
        }
    }
}
