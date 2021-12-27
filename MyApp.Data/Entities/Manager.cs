using System.ComponentModel.DataAnnotations;

namespace MyApp.Data.Entities
{
    public class Manager
    {
        public int Id { get; set; }
        [Required]
        public Users User { get; set; }
    }
}