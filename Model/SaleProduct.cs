using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class SaleProduct
    {
        /// <summary>
        /// Chave estrangeira da tabela Sales
        /// </summary>
        public int SaleId { get; set; }
        /// <summary>
        /// Chave estrangeira da tabela Products
        /// </summary>
        public int ProductId { get; set; }
        /// <summary>
        /// Venda
        /// </summary>
        public virtual Sale Sale { get; set; }
        /// <summary>
        /// Produto vendido
        /// </summary>
        public virtual Product Product { get; set; }        
        /// <summary>
        /// Quantidade do produto vendido
        /// </summary>
        public int Quantity { get; set; }
    }
}
