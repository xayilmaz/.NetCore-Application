using MyApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Business.Responses.User
{
    public class PostUserResponse
    {
        public int Id { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public Departments Departments { get; set; }
    }
}
