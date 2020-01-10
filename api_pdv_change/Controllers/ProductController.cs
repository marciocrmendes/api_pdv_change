using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infra.Config;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace api_pdv_change.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly DbContext _context;


        private ILogger _logger;

        public ProductController(DbContext context, ILogger<ProductController> logger)
        {
            _context = context;
            _logger = logger;
        }

        //public IActionResult GetAll()
        //{
        //    _context.
        //}
    }
}