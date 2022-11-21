using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn_4_Minneshantering // Egenkonstruerad metod (klass) för att göra samma sak.
{
    public static class Generator
    {
        public static int OddGenerator(int n)
        {
            if (n == 0) return 1;

            if (n < 0) return n * 2 + 1;

            return n * 2 - 1;
        }
    }
}
