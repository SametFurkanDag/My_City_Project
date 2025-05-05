using System.ComponentModel.DataAnnotations;

namespace My_City_Project.Model.Entities
{
    public class Places
    {
        [Key]
        public Guid PlaceId { get; set; } = Guid.NewGuid();
        public string PlaceName { get; set; }
        public string PlaceLocation { get; set; }
    }

}
