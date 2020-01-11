using Infra.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_pdv_change.Controllers
{
    [ApiController]
    [Route("api/[controller]/")]
    public class SaleController : ControllerBase
    {
        private readonly ISaleService _service;
        private readonly ILogger _logger;

        public SaleController(ISaleService service, ILogger<SaleController> logger)
        {
            _service = service;
            _logger = logger;
        }

        [Route("test")]
        public IActionResult Test()
        {
            return new JsonResult("dsadsadsa");
        }
    }
}
