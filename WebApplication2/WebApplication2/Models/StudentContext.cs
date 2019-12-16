using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace WebApplication2.Models
{
    public class StudentContext:DbContext
    {
        public DbSet<Student> StudentList { get; set; }
        public DbSet<Employee> Employees { get; set; }
        //public DbSet<Users> UserRegister { get; set; }
    }
}