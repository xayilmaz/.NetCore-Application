﻿using System;
using System.ComponentModel.DataAnnotations;

namespace MyApp.Data.Entities
{
    public class Task
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public bool IsApproved { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public Users CreatedBy { get; set; }
        [Required]
        public Customer Customer { get; set; }
    }
}