namespace Store.Models.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public long IdentificationNumber { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public long Phone { get; set; }
        public bool State { get; set; }
    }
}