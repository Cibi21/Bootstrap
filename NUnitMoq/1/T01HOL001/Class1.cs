using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Addition;
using NUnit.Framework;

namespace T01HOL001
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void Add_TwoNumbersGivenAsInputWhichAreGreaterThanZero_ReturnSumOfTwoNumbers()
        {
            T01_HOL_001 bm = new T01_HOL_001();
            double res = bm.Add(10, 10);
            Assert.That(res, Is.EqualTo(20));
        }
        [Test]
        public void Add_OneOfTheTwoNumbersIsLessThanZero_ReturnZero()
        {
            T01_HOL_001 bm = new T01_HOL_001();
            double res = bm.Add(10, -10);
            Assert.That(res, Is.EqualTo(0));
        }
    }
    public class Class1
    {
    }
}
