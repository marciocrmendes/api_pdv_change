using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infra.Config;
using Infra.Interfaces.IServices;
using Infra.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace api_pdv_change.Controllers
{
    [ApiController]
    [Route("api/[controller]/")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        private ILogger _logger;

        public ProductController(IProductService productService, ILogger<ProductController> logger)
        {
            _productService = productService;
            _logger = logger;
        }

        [Route("getall")]
        public IActionResult GetAll()
        {
            var products = _productService.GetAll();

            if (! products.Any())
            {
                throw new Exception("Não há nenhum produto cadastrado");
            }

            var json = new JsonResult(products);

            return json;
        }


        public IActionResult GetById(int id)
        {
            var product = _productService.GetById(id);

            if (product == null)
            {
                throw new Exception("Não há nenhum produto cadastrado");
            }

            var json = new JsonResult(product);

            return json;
        }
    }
}