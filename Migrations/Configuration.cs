namespace StudentManager.Migrations
{
    using StudentManager.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<StudentManager.Models.StudentManagerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(StudentManager.Models.StudentManagerContext context)
        {

            Student st1 = new Student();

            st1.Name = "Aman";
            st1.Email = "aman@gmail.com";
            st1.Telephone = "078225452";
            st1.Married = false;
            st1.DoB = DateTime.Parse("12/12/2000");



            Student st2 = new Student();

            st2.Name = "rosine";
            st2.Email = "rosine@gmail.com";
            st2.Telephone = "078225452";
            st2.Married = true;
            st2.DoB = DateTime.Parse("1/10/2000");



            context.students.AddOrUpdate(p => p.Name, st1, st2);


            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
