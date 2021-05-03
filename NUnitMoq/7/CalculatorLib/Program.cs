using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLib
{
    public class T02HOL006_Logic
    {
        public int Divide(int dividend, int devisor)
        {
            try
            {
                return dividend / devisor;
            }
            catch
            {
                throw new DivideByZeroException("You are trying to divide by zero");
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
