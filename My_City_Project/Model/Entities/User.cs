using System.ComponentModel.DataAnnotations;

namespace My_City_Project.Model.Entities
{
    public class User
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }

}

