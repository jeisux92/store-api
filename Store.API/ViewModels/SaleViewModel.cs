using System.Collections.Generic;

namespace Store.API.ViewModels
{
    public class Sale
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
    public class SaleViewModel
    {
        public long IdentificationNumber { get; set; }
        public IEnumerable<Sale> Sale { get; set; }
    }
}
