using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace KnockoutExamples.Controllers
{
    [Route("api/[controller]")]
    public class DataApiController : Controller
    {
        [HttpGet]
        public string Test()
        {
            return "Testowy string";
        }
    }
}
