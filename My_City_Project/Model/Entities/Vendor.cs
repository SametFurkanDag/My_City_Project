using System.ComponentModel.DataAnnotations;
namespace My_City_Project.Model.Entities
{
    public class Vendor
    {
        [Key]
        public Guid VendorId { get; set; } = Guid.NewGuid();
        public string VendorName { get; set; }
      
    }

}
