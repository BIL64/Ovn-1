using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn_4_Minneshantering
{
    public static class Iterative // Omändrad!
    {
        public static int IterativeOdd(int n)
        {
            int result = 1;

            for (int i = 0; i < n - 1; i++)
            {
                result += 2;
            }

            return result;
        }
    }
}
