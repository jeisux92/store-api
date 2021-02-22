using System;

namespace Store.Models.DTO
{
    public class SaleCustomerDto
    {
        public long CustomerId { get; set; }
        public string CustomerName { get; set; }
        public DateTime CreatedOn { get; set; }
        public long Total { get; set; }
    }
}
