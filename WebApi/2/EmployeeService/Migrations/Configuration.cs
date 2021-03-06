namespace EmployeeService.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using EmployeeService.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<EmployeeService.Data.EmployeeServiceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(EmployeeService.Data.EmployeeServiceContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Departments.AddOrUpdate(
                  p => p.Id,
                  new Department() { Id = 100, Name = "HR" },
                  new Department() { Id = 101, Name = "Technical" }

                );
            context.Employees.AddOrUpdate(
                  p => p.Id,
                  new Employee() { Id = 1, FirstName = "John", LastName = "Smith", Salary = 30000, DepartmentId = 101 },
                  new Employee() { Id = 1, FirstName = "Mary", LastName = "Jane", Salary = 20000, DepartmentId = 101},
                  new Employee() { Id = 1, FirstName = "Steve", LastName = "Lopez", Salary = 50000, DepartmentId = 101 }

                );
        }
    }
}
