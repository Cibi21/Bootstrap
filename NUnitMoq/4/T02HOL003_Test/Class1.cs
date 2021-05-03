using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MathLibrary;

namespace T02HOL003_Test
{
    [TestFixture]
    public class T02HOL003_UnitTests
    {
        T02HOL003 script = new T02HOL003();
        [Test]
        [TestCaseSource(nameof(TestCases))]
        public void CompareTwoNumbers(int FirstNumber, int SecondNumber, int result)
        {
            var answer = script.CompareTwoNumbers(FirstNumber, SecondNumber);
            Assert.That(answer, Is.EqualTo(result));

        }

        static readonly object[] TestCases =
        {
            new object[] {-1,0,0},
            new object[] {1,2,-1},
            new object[] {2,1,1}
        };
    }
    public class Class1
    {
    }
}
