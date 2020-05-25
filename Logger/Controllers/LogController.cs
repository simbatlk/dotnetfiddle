using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Logger.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LogController : ControllerBase
    {
        private readonly ILogger<LogController> _logger;

        public LogController(ILogger<LogController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get([FromQuery] int adUnitId = 0)
        {
            if (adUnitId != 0)
            {
                return new OkObjectResult("Okey");
            }

            return new BadRequestObjectResult("You positively must pass an ID");
        }
    }
}