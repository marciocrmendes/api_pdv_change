using Infra.Interfaces.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_pdv_change.Controllers
{
    /// <summary>
    /// Controller responsável pelos dados de Venda
    /// </summary>
    [ApiController]
    [Route("api/[controller]/")]
    public class SaleController : ControllerBase
    {
        private readonly ISaleService _saleService;
        private readonly IBanknoteService _banknoteService;
        private readonly ILogger _logger;

        /// <summary>
        /// Construtor
        /// </summary>
        public SaleController(
            ISaleService saleService,
            IBanknoteService banknoteService,
            ILogger<SaleController> logger)
        {
            _saleService = saleService;
            _banknoteService = banknoteService;
            _logger = logger;
        }

        /// <summary>
        /// Detalha a compra pesquisada
        /// </summary>
        /// <param name="saleId">Id da compra</param>
        /// <returns></returns>
        [Route("details/{saleId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet]
        public IActionResult Details(int? saleId)
        {
            if(!saleId.HasValue)
            {
                return StatusCode(StatusCodes.Status400BadRequest, "Id não pode ser nulo"); 
            }

            var sale = _saleService.GetById(saleId.Value);
            if (sale == null)
            {
                return StatusCode(StatusCodes.Status404NotFound, "Venda não encontrada");
            }

            string text = string.Empty;
            foreach (var banknote in sale.Banknotes)
            {
                if (banknote.Banknote.Type == Entities.Enum.BankNoteEnum.Note)
                {
                    text += @$"
                        {banknote.Quantity} nota(s) de {banknote.Banknote.Value} reais \n
                    ";
                }
                else
                {
                    text += @$"
                        {banknote.Quantity} moeda(s) de {banknote.Banknote.Value} centavos \n
                    ";
                }
            }

            var json = new
            {
                description = text,
                details = sale
            };

            return new JsonResult(json);
        }
    }
}
