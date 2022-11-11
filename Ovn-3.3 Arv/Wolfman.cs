using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn_3._3_Arv
{
    internal class Wolfman : Wolf, IPerson
    {
        private string Name { get; set; }
        public int Weight { get; set; }
        public int Age { get; set; }

        public void Talk(string wolfman) { } // Denna var tvunget att implementeras.

        public Wolfman(string name, int weight, int age, string wolfman) // Denna sköter all input.
        {
            Name = name;
            Weight = weight;
            Age = age;

            IPerson pers = new Person(Name, Weight, Age); // Tyvärr var Person (inte IPerson) tvunget att implementeras.
            pers.Talk(wolfman);
        }
    }
}
