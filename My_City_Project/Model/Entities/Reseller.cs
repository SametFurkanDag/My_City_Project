using System;
using System.ComponentModel.DataAnnotations;

namespace My_City_Project.Model.Entities
{
    public class Reseller
    {
        [Key]
        public Guid ResellerId { get; set; } = Guid.NewGuid(); 
        public string ResellerName { get; set; }
        public string ResellerLocation { get; set; }
    }
}
