using NPOI.HPSF;
using System.ComponentModel.DataAnnotations;


namespace My_City_Project.Model.Entities
{
    public class Cart
    {
        [Key]
        public Guid CartId { get; set; } = Guid.NewGuid();
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    }


}
