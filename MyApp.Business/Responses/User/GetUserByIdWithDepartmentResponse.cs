using System;
using System.Collections.Generic;
using System.Text;
using MyApp.Data.Entities;

namespace MyApp.Business.Responses.User
{
    public class GetUserByIdWithDepartmentResponse
    {
        public int Id { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public virtual Departments Departments { get; set; }
        public virtual Role Role { get; set; }
    }
}
