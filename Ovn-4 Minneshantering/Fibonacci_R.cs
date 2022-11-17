using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn_4_Minneshantering // 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597...
{
    public static class Fibonacci_R
    {
        public static int Fibonaccisekvens(int n)
        {
            if (n <= 1) return n;

            return Fibonaccisekvens(n - 1) + Fibonaccisekvens(n - 2);
        }
    }
}
