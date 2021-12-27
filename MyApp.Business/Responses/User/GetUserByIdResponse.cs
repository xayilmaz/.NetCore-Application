using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Business.Responses.User
{
    public class GetUserByIdResponse
    {
        public int Id { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
    }
}
