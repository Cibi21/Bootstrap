using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public class T02HOL003
    {
        public int CompareTwoNumbers(int a, int b)
        {
            if (a <= 0 && b <= 0)
                return 0;
            else if (a >= b)
                return 1;
            else
                return -1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
