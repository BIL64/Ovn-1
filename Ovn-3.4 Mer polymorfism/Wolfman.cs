using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn_3._3_Arv // Detta hör till uppgift 3.4 Mer polymorfism!
{
    internal class Wolfman : Wolf, IPerson
    {
        private string Name { get; set; }
        public string Weight { get; set; }
        public string Age { get; set; }
        public string[] MyArray; // Arraydeklaration nr 3.

        public string[] Talk(string wolfman) // Denna var tvunget att implementeras.
        {
            throw new NotImplementedException();
        }

        public Wolfman(string name, string weight, string age, string wolfman) // Denna sköter all input.
        {
            Name = name;
            Weight = weight;
            Age = age;

            IPerson pers = new Person(Name, Weight, Age); // Tyvärr var Person (inte IPerson) tvunget att implementeras.
            MyArray = pers.Talk(wolfman);
        }
    }
}
