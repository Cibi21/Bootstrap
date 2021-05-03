using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handson3
{
    public class EmployeeFunction
    {
        public List<Employee> employees = new List<Employee>()
        {
            new Employee(){id=99,name="Nithin",year=2015},
            new Employee(){id=100,name = "Radha",year=2020},
            new Employee(){id=101,name="Nidharshana",year=2020},
            new Employee(){id=102,name="Shri",year=2016}
        };
        public IEnumerable<Employee> GetEmployees()
        {

            return this.employees;
        }
        public IEnumerable<Employee> GetEmployeesWhoHasJoinedPreviousYear()
        {
            return this.employees.Where(item => item.year == 2020);
        }
        public class Employee
        {
            public int id { get; set; }
            public string name { get; set; }
            public int year { get; set; }
        }
        class Program
        {
            static void Main(string[] args)
            {
            }
        }
    }
}