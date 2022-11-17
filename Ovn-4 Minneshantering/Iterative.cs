using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn_4_Minneshantering
{
    public static class Iterative
    {
        public static int IterativeOdd(int n)
        {
            if (n == 0) return n;

            int result = 1;

            for (int i = 1; i <= n; i++)
            {
                result += 2;
            }

            return result;
        }
    }
}
