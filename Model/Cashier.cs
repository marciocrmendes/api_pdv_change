using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Cashier : BaseModel
    {
        /// <summary>
        /// Nome do ponto de venda
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Total do caixa
        /// </summary>
        public decimal Total { get; set; }
    }
}
