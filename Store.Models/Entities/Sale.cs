using System;

namespace Store.Models.Entities
{
    public class Sale
    {
        public int Id { get; set; }
        public long CustomerId { get; set; }
        public long Total { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
