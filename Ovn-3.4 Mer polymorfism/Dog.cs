using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn_3._3_Arv // Detta hör till uppgift 3.4 Mer polymorfism!
{
    internal class Dog
    {
        public string Trait
        {
            get { return "Barks"; }
        }

        public string WildstringDog()
        {
            return "15. Specialsträng endast från Dog-klassen...\n";
        }
    }
}
