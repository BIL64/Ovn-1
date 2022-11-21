using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn_4_Minneshantering // 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597...
{
    public static class Fibonacci_I
    {
        public static double Fibonaccisekvens(int n)
        {
            ulong a = 0, b = 1, c; // Utökad gräns med ulong.
            if (n == 0) return a;

            for (long i = 2; i <= n; i++) // Utökad gräns med long.
            {
                c = a + b;
                a = b;
                b = c;
            }
            return b;
        }
    }
}
