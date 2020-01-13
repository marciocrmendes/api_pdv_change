using Infra.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities;
using Microsoft.AspNetCore.Http;

namespace api_pdv_change.Controllers
{
    /// <summary>
    /// Controller responsável pelo calculo do troco
    /// </summary>
    [ApiController]
    [Produces("application/json")]
    [Route("api/[controller]/")]
    public class ChangeController : ControllerBase
    {
        private readonly ISaleService _saleService;
        private readonly IBanknoteService _banknoteService;
        private readonly ILogger _logger;

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="saleService"></param>
        /// <param name="banknoteService"></param>
        /// <param name="logger"></param>
        public ChangeController(
            ISaleService saleService, 
            IBanknoteService banknoteService, 
            ILogger<ChangeController> logger)
        {
            _saleService = saleService;
            _banknoteService = banknoteService;
            _logger = logger;
        }

        /// <summary>
        /// Retorna o troco, se houver necessidade
        /// </summary>
        /// <param name="totalSelling">Total da compra</param>
        /// <param name="givenValue">Total do valor dado pelo cliente</param>
        /// <returns></returns>
        [Route("getchange/{totalSelling}/{givenValue}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet]
        public IActionResult Change(decimal? totalSelling, decimal? givenValue)
        {
            if(! totalSelling.HasValue)
            {
                _logger.LogError($"Valor total da compra está vazio");
                return StatusCode(StatusCodes.Status400BadRequest, "Valor total da compra está vazio");
            }

            if(! givenValue.HasValue)
            {
                _logger.LogError($"Valor total dado pelo cliente da compra está vazio");
                return StatusCode(StatusCodes.Status400BadRequest, "Valor total dado pelo cliente da compra está vazio");
            }

            if(totalSelling.Value > givenValue.Value)
            {
                return StatusCode(StatusCodes.Status400BadRequest, "Valor total dado pelo é menor que o valor total da compra");
            }

            if(totalSelling.Value == givenValue.Value)
            {
                return StatusCode(StatusCodes.Status400BadRequest, "Não há necessidade de troco");
            }

            var banknotes = _banknoteService.GetAll().OrderByDescending(x => x.Value);

            var banknotesChange = new List<SaleBanknote>();
            CalculateBanknoteChange(banknotesChange, banknotes, givenValue.Value, totalSelling.Value, out string details);

            return new JsonResult(
                new
                {
                    details = details
                });
        }

        private void CalculateBanknoteChange(
            IList<SaleBanknote> banknotesChange, 
            IEnumerable<Banknote> banknotes, 
            decimal givenValue,
            decimal totalSelling,
            out string details)
        {
            details = string.Empty;
            var changeValue = givenValue - totalSelling;

            if (changeValue > 0)
            {
                var sale = new Sale()
                {
                    Total = totalSelling,
                    Descount = 0
                };
                _saleService.Add(sale);

                CalculateNotes(banknotesChange, banknotes, changeValue, out int totalRest, out string detailsNotes);
                CalculateCents(banknotesChange, banknotes, changeValue, totalRest, out string detailsCents);

                details = detailsNotes + detailsCents;

                if (banknotesChange.Any())
                {
                    sale.Banknotes = banknotesChange;
                    _saleService.Update(sale);
                }
            }
        }

        private void CalculateNotes(
            IList<SaleBanknote> banknotesChange, 
            IEnumerable<Banknote> banknotes, 
            decimal total,
            out int totalRest,
            out string details)
        {
            details = string.Empty;
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

                    details += @$"
                        {qtdNotes} nota(s) de {note.Value * 100} reais\n
                    ";

                    banknotesChange.Add(new SaleBanknote()
                    {
                        BanknoteId = note.Id,
                        Quantity = qtdNotes
                    });
                }
            }
        }

        private void CalculateCents(
            IList<SaleBanknote> banknotesChange, 
            IEnumerable<Banknote> banknotes, 
            decimal total, 
            int totalRest,
            out string details)
        {
            details = string.Empty;
            var totalDecimal = total - totalRest;
            var coins = banknotes.Where(x => x.Type == Entities.Enum.BankNoteEnum.Coin);

            foreach (var coin in coins)
            {
                var noteValue = coin.Value;
                var qtdCoins = (int)(totalDecimal / noteValue);

                if (qtdCoins != 0)
                {
                    totalDecimal %= noteValue;

                    details += @$"
                        {qtdCoins} moeda(s) de {coin.Value} centavos\n
                    ";

                    banknotesChange.Add(new SaleBanknote()
                    {
                        BanknoteId = coin.Id,
                        Quantity = qtdCoins
                    });
                }
            }
        }
    }
}
