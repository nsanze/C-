using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudentSecurityManager.Models
{
    public class StudentSecurityManagerContext : DbContext
    {
        public StudentSecurityManagerContext() : base("DefaultConnection")
        {

        }
        public DbSet<Student> students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }

    }
}