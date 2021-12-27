using System.ComponentModel.DataAnnotations;

namespace MyApp.Data.Entities
{
    public class UserManager
    {
        public int Id { get; set; }
        [Required]
        public Users User { get; set; }
        [Required]
        public Manager Manager { get; set; }
    }
}