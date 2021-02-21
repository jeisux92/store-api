using System.ComponentModel.DataAnnotations.Schema;

namespace Store.Models.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long UnitValue { get; set; }
        public bool State { get; set; }
    }
}