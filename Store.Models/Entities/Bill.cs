namespace Store.Models.Entities
{
    public class Bill
    {
        public int Id { get; set; }
        public int SaleId { get; set; }
        public int ProductId { get; set; }
        public long Quantity { get; set; }
    }
}
