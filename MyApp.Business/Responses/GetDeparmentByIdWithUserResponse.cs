﻿using System.Collections.Generic;
using MyApp.Data.Entities;

namespace MyApp.Business.Responses
{
    public class GetDeparmentByIdWithUserResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}