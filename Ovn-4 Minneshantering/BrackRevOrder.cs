using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn_4_Minneshantering // Test av bakoframvända parenteser.
{
    public static class BrackRevOrder
    {
        public static bool Test(List<char> listan)
        {
            string test = "";
            bool b_swap = false;

            foreach (var item in listan) { test += item.ToString(); } // Omvandlar char i listan till en sträng.

            if (test.IndexOf("[)()") != -1) b_swap = true;
            if (test.IndexOf("()(]") != -1) b_swap = true;
            if (test.IndexOf("[)(]") != -1) b_swap = true;
            if (test.IndexOf("{)()") != -1) b_swap = true;
            if (test.IndexOf("()(}") != -1) b_swap = true;
            if (test.IndexOf("{)(}") != -1) b_swap = true;

            if (test.IndexOf("(][)") != -1) b_swap = true;
            if (test.IndexOf("[][)") != -1) b_swap = true;
            if (test.IndexOf("(][]") != -1) b_swap = true;
            if (test.IndexOf("]][)") != -1) b_swap = true;
            if (test.IndexOf("(][[") != -1) b_swap = true;
            if (test.IndexOf("{][)") != -1) b_swap = true;
            if (test.IndexOf("(][}") != -1) b_swap = true;
            if (test.IndexOf("{][}") != -1) b_swap = true;

            if (test.IndexOf("(][(") != -1) b_swap = true;
            if (test.IndexOf(")][)") != -1) b_swap = true;

            if (test.IndexOf("(}{)") != -1) b_swap = true;
            if (test.IndexOf("[}{)") != -1) b_swap = true;
            if (test.IndexOf("(}{]") != -1) b_swap = true;
            if (test.IndexOf("[}{]") != -1) b_swap = true;
            if (test.IndexOf("{}{)") != -1) b_swap = true;
            if (test.IndexOf("(}{}") != -1) b_swap = true;

            if (test.IndexOf("(}{(") != -1) b_swap = true;
            if (test.IndexOf(")}{)") != -1) b_swap = true;
            if (test.IndexOf("]}{)") != -1) b_swap = true;
            if (test.IndexOf("(}{[") != -1) b_swap = true;

            return b_swap;
        }
    }
}
