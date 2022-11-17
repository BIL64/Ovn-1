using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn_4_Minneshantering
{
    public static class Recursive
    {
        public static int RecursiveOdd(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return (RecursiveOdd(n - 1) + 2);
        }
    }
}
