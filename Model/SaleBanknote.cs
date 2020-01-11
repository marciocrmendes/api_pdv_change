namespace Entities
{
    public class SaleBanknote
    {
        /// <summary>
        /// Chave estrangeira da tabela Sales
        /// </summary>
        public int SaleId { get; set; }
        /// <summary>
        /// Chave estrangeira da tabela Banknote
        /// </summary>
        public int BanknoteId { get; set; }
        /// <summary>
        /// Quantidade das respectivas notas usadas na compra
        /// </summary>
        public int Quantity { get; set; }
        /// <summary>
        /// Venda
        /// </summary>
        public virtual Sale Sale { get; set; }
        /// <summary>
        /// Cédula ou moeda que saiu
        /// </summary>
        public virtual Banknote Banknote { get; set; }
    }
}