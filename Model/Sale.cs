using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    public class Sale : BaseModel
    {
        /// <summary>
        /// Total do desconto da venda
        /// </summary>
        public decimal? Descount { get; set; }
        /// <summary>
        /// Total da venda
        /// </summary>
        public decimal Total { get; set; }
        /// <summary>
        /// Data de venda
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Lista de produtos e suas respectivas quantidades vendidas
        /// </summary
        public virtual IList<SaleProduct> ProductsSold { get; set; } = new List<SaleProduct>();
        /// <summary>
        /// Notas utilizadas na compra
        /// </summary>
        public virtual IList<SaleBanknote> Banknotes { get; set; } 
    }
}
