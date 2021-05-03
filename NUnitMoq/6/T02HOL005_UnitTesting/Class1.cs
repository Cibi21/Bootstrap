using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using T02HOL005;

namespace T02HOL005_UnitTesting
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            Employee employee1 = new Employee();
            EmployeeManager logic = new EmployeeManager();
            Assert.That(0, Is.EqualTo(logic.HeadCount));
        }
        [Test]
        public void TestMethod2()
        {
            Employee employee1 = new Employee()
            {
                Id = 1001,
                Name = "Cibi"
            };
            EmployeeManager logic = new EmployeeManager();
            logic.AddEmployee(employee1);
            Assert.That(1, Is.EqualTo(logic.HeadCount));
        }
    }
    public class Class1
    {
    }
}
