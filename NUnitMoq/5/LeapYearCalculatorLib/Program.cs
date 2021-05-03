using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYearCalculatorLib
{
    public class T02HOL004
    {
        public int LeapYearCalculatorLib(int year)
        {
            if (year < 1753 && year > 9999)
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
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
