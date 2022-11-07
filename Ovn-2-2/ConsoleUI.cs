using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn_2_2
{
    internal class ConsoleUI : IUI // Lokal.
    {
        public int R() // int här, resten string.
        {
            return Console.Read();
        }

        public string RL()
        {
            return Console.ReadLine()!;
        }

        public void W(string input)
        {
            Console.Write(input);
        }

        public void WL(string input)
        {
            Console.WriteLine(input);
        }
    }
}
