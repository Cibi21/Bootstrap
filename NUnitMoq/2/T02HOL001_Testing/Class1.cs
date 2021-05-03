using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using T02HOL001_Logic;

namespace T02HOL001_Testing
{
    [TestFixture]
    public class T02HOL001_UnitTests
    {
        T02HOL001 logicScript = new T02HOL001();
        [Test]
        public void Add_InputTwoNumbers_ReturnSumOfTWoNumbers()
        {
            var result = logicScript.Add(5, 10);
            Assert.That(result, Is.EqualTo(15));
        }
        [Test]
        public void Subtract_InputTwoNumbers_ReturnDifferenceOfTwoNumbers()
        {
            var result = logicScript.Subtract(10, 5);
            Assert.That(result, Is.EqualTo(5));
        }
        [Test]
        public void Multiply_InputTWoNumbers_ReturnProductOFTwoNumbers()
        {
            var result = logicScript.Multiply(3, 5);
            Assert.That(result, Is.EqualTo(15));
        }
        [Test]
        //[Ignore("Thats what the hands on document said")]
        public void Divide_InputTwoNumbers_ReturnQuotientOfTWoNumbers()
        {
            var result = logicScript.divide(20, 5);
            Assert.That(result, Is.EqualTo(4));
        }
        [Test]
        [TestCaseSource(nameof(TestCaseValues))]
        public void Add_MultipleInputs_MultipleOutputs(double a, double b)
        {
            var result = logicScript.Add(a, b);
            Assert.That(result, Is.EqualTo(a + b));

        }
        static readonly object[] TestCaseValues =
        {
            new object[] {10,5},
            new object[] {3,8},
            new object[] {10,20}
        };

    }
    public class Class1
    {
    }
}
