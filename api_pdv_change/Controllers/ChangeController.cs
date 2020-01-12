using Infra.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities;

namespace api_pdv_change.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/[controller]/")]
    public class ChangeController : ControllerBase
    {
        private readonly ISaleService _saleService;
        private readonly IBanknoteService _banknoteService;
        private readonly ILogger _logger;

        public ChangeController(
            ISaleService saleService, 
            IBanknoteService banknoteService, 
            ILogger<SaleController> logger)
        {
            _saleService = saleService;
            _banknoteService = banknoteService;
            _logger = logger;
        }

        [Route("test")]
        public IActionResult Test()
        {
            return new JsonResult(new { });
        }

        /// <summary>
        /// Retorna o troco, se houver necessidade
        /// </summary>
        /// <param name="totalSelling">Total da compra</param>
        /// <param name="givenValue">Total do valor dado pelo cliente</param>
        /// <returns></returns>
        [Route("getchange/{totalSelling}/{givenValue}")]
        [HttpGet]
        public IActionResult Change(decimal? totalSelling, decimal? givenValue)
        {
            if(! totalSelling.HasValue)
            {
                _logger.LogError($"Valor total da compra está vazio");
                return StatusCode(500, "Valor total da compra está vazio");
            }

            if(! givenValue.HasValue)
            {
                _logger.LogError($"Valor total dado pelo cliente da compra está vazio");
                return StatusCode(400, "Valor total dado pelo cliente da compra está vazio");
            }

            if(totalSelling.Value > givenValue.Value)
            {
                return StatusCode(400, "Valor total dado pelo é menor que o valor total da compra");
            }

            if(totalSelling.Value == givenValue.Value)
            {
                return StatusCode(200, "Não há necessidade de troco");
            }

            var banknotes = _banknoteService.GetAll().OrderByDescending(x => x.Value);

            var banknotesChange = new List<SaleBanknote>();
            CalculateBanknoteChange(banknotesChange, banknotes, givenValue.Value, totalSelling.Value);

            return new JsonResult(banknotesChange);
        }

        private void CalculateBanknoteChange(
            IList<SaleBanknote> banknotesChange, IEnumerable<Banknote> banknotes, decimal givenValue, decimal totalSelling)
        {
            var changeValue = givenValue - totalSelling;

            if (changeValue > 0)
            {
                CalculateNotes(banknotesChange, banknotes, changeValue, out int totalRest);
                CalculateCents(banknotesChange, banknotes, changeValue, totalRest);
            }
        }

        private void CalculateNotes(IList<SaleBanknote> banknotesChange, IEnumerable<Banknote> banknotes, decimal total, out int totalRest)
        {
            totalRest = 0;
            var totalInt = (int)total;

            var notes = banknotes.Where(x => x.Type == Entities.Enum.BankNoteEnum.Note);
            
            foreach (var note in notes)
            {
                var noteValue = (int)note.Value;
                int qtdNotes = totalInt / noteValue;

                if (qtdNotes != 0)
                {
                    totalInt %= noteValue;
                    totalRest += noteValue;

                    banknotesChange.Add(new SaleBanknote()
                    {
                        BanknoteId = note.Id,
                        Banknote = note,
                        Quantity = qtdNotes
                    });
                }
            }
        }

        private void CalculateCents(IList<SaleBanknote> banknotesChange, IEnumerable<Banknote> banknotes, decimal total, int totalRest)
        {
            var totalDecimal = total - totalRest;
            var coins = banknotes.Where(x => x.Type == Entities.Enum.BankNoteEnum.Coin);

            foreach (var coin in coins)
            {
                var noteValue = coin.Value;
                var qtdCoins = (int)(totalDecimal / noteValue);

                if (qtdCoins != 0)
                {
                    totalDecimal %= noteValue;
                    banknotesChange.Add(new SaleBanknote()
                    {
                        BanknoteId = coin.Id,
                        Banknote = coin,
                        Quantity = qtdCoins
                    });
                }
            }
        }
    }
}
