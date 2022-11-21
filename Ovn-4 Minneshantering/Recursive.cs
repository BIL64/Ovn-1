using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn_4_Minneshantering
{
    public static class Recursive
    {
        public static int RecursiveOdd(int n) // Omändrad!
        {
            if (n <= 1) // Jag ändrade till ett <= så att inte n = 0 och mindre tal kan hamna i den negativa avgrunden.
            {
                return 1;
            }
            return (RecursiveOdd(n - 1) + 2);
        }
    }
}
