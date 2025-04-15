using System.ComponentModel.DataAnnotations;

namespace My_City_Project.Entities
{
    public class Places
    {
        [Key]
        public int PlaceId { get; set; }

        public string PlaceName { get; set; }

        public string PlaceLocation { get; set; }
    }
}
