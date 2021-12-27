using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using MyApp.Data.Entities;

namespace MyApp.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public virtual DbSet<Departments> Deparments { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Manager> Managers { get; set; }
        public virtual DbSet<UserManager> UserManagers { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<Issue> Issues { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<IssueLog> IssueLogs { get; set; }
    }
}
