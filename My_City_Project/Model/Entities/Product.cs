using System; // Guid için eklendi
using System.ComponentModel.DataAnnotations;

namespace My_City_Project.Model.Entities
{
    public class Product
    {
        [Key]
        public Guid ProductId { get; set; } = Guid.NewGuid();
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public Guid VendorId { get; set; }
    }

}
