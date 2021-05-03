using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CalculatorLib;

namespace T02HOL006_Testing
{
    [TestFixture]
    public class T02HOL006_Testing
    {
        T02HOL006_Logic script = new T02HOL006_Logic();
        [Test]
        public void Divide_DividendAndDivisorIsNotZero_ReturnTheQuotient()
        {
            var result = script.Divide(20, 4);
            Assert.That(result, Is.EqualTo(5));
        }
        [Test]
        public void Divide_TheDiviorIsZero_ThrowDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => script.Divide(20, 4));
        }
    }

public class Class1
    {

    }
}
