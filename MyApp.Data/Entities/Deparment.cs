using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace MyApp.Data.Entities
{
    public class Departments
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [IgnoreDataMember]
        public virtual ICollection<Users> Users{ get; set; }
    }
}