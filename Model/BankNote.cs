using Entities.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Banknote : BaseModel
    {
        /// <summary>
        /// Valor da cédula ou moeda
        /// </summary>
        public decimal Value { get; set; }
        /// <summary>
        /// Checa se é moeda ou cédula
        /// </summary>
        public BankNoteEnum Type { get; set; }
        /// <summary>
        /// Venda em que a nota esteja
        /// </summary>
        public virtual IList<SaleBanknote> Sales { get; set; } = new List<SaleBanknote>();
    }
}
