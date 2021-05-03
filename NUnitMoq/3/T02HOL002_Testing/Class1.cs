using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Handson3;
using static Handson3.EmployeeFunction;

namespace T02HOL002_Testing
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void GetEmployees_AccessThePredefinedEmployeeObject_CheckIfAnyNullValueIsAvailable()
        {
            EmployeeFunction employeeFunction = new EmployeeFunction();
            Assert.That(employeeFunction.GetEmployees(), !Is.Null);
        }
        [Test]
        public void GetEmployees_TraverseThroughTheEmployeeObject_CheckIfAnyPersonsIdIs100()
        {
            EmployeeFunction employeeFunction = new EmployeeFunction();
            var people = employeeFunction.GetEmployees();
            Assert.That(people.Any(p => p.id == 100));
        }
        [Test]
        public void GetEmployees_TraverseThroughEmployeesData_CheckIfAllDataAreUniqueBasedOnId()
        {
            EmployeeFunction employeeFunction = new EmployeeFunction();
            IEnumerable<Employee> employees = employeeFunction.GetEmployees();
            Assert.That(employees.Select(item => item.id), Is.Unique);
        }
        [Test]
        public void CheckIfGetEmployeesAndGetEmployeesWhoHasJoinedThePreviousYearHasDifferentData()
        {
            EmployeeFunction employeeFunction = new EmployeeFunction();
            IEnumerable<Employee> employees = employeeFunction.GetEmployees();
            IEnumerable<Employee> employees1 = employeeFunction.GetEmployeesWhoHasJoinedPreviousYear();
            Assert.That(employees, !Is.EqualTo(employees1));
        }
    }
}

