using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using LeapYearCalculatorLib;

namespace T02HOL004
{
    [TestFixture]
    public class UnitTest1
    {
        T02HOL004 script = new T02HOL004();
        [Test]
        [TestCaseSource(nameof(TestCaseValues))]
        public void LeapYearCalculatorLib_CheckIfTheYearsProvidedAreLeapYears(int year, int output)
        {
            var result = script.LeapYearCalculatorLib(year);
            Assert.That(result, Is.EqualTo(output));
        }
        static readonly object[] TestCaseValues =
        {
            new object[] {1638,-1},
            new object[] {2028,1},
            new object[] {2007,0},new object[] {10000,-1}
        };
    }
    public class T02HOL004
    {
        public int LeapYearCalculatorLib(int year)
        {
            if (year < 1753 || year > 9999)
                return -1;
            else
            {
                if (DateTime.IsLeapYear(year))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
    public class Class1
    {
    }
}
