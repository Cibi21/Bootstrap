using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition
{
    public class T01_HOL_001
    {
        public double Add(double num1, double num2)
        {
            if (num1 < 0 || num2 < 0)
                return 0;
            return num1 + num2;
        }
    }
}
