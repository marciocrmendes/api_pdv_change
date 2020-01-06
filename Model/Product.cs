using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Product : BaseModel
    {
        /// <summary>
        /// Nome do produto
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Preço do produto
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Desconto do produto
        /// </summary>
        //public decimal Descount { get; set; }
        /// <summary>
        /// Vendas realizadas do produto
        /// </summary>
        public virtual IList<SaleProduct> Sales { get; set; } = new List<SaleProduct>();
    }
}