using System.ComponentModel.DataAnnotations;

namespace MyApp.Data.Entities
{
    public class Users

    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirsName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [MaxLength(50)]
        public string Password { get; set; }
        [Required]
        public virtual Departments Deparment { get; set; }
        [Required]
        public virtual Role Role { get; set; }
    }
}
