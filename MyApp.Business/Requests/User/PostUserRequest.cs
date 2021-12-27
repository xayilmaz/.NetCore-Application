using MyApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Business.Requests.User
{
    public class PostUserRequest
    {
        public string FirsName { get; set; }
        public string LastName { get; set; }

        public Departments Departments { get; set; }
    }
}
