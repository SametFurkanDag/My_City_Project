using System.ComponentModel.DataAnnotations;
namespace My_City_Project.Model.Entities
{
    public class Report
    {
        [Key]
        public Guid ReportId { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime ReportDate { get; set; }
    }

}
