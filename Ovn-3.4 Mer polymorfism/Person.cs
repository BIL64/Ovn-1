using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn_3._3_Arv // Detta hör till uppgift 3.4 Mer polymorfism!
{
    internal class Person : Animal, IPerson
    {
        public string[] Talk(string amal) // Själva utskriften och som returnerar en array.
        {
            string[] animarray = new string[7]; // Array nr 2 färdigställs.
            animarray[0] = "This is a " + amal + "."; // Typ
            animarray[1] = "Name: " + Outname(); // Namn
            animarray[2] = "Weight: " + Outweight() + " pounds"; // Vikt
            animarray[3] = "Age: " + Outage() + " year"; // Ålder
            animarray[4] = "Attribute: " + Stats(amal); // Egenskap
            if (amal == "wolf") animarray[5] = "Sound like: " + DoSound(amal) + " I love this animal !!!"; // Wolfman gillar
            else animarray[5] = "Sound like: " + DoSound(amal); // Typiskt ljud
            animarray[6] = "------------------------------------";

            //DogPrint(); // Här kan man skriva ut i Animal med metoden DogPrint.

            return animarray;
        }

        public Person(string name, string weight, string age) : base("null", "0", "0") // Denna var tvunget att inplementeras.
        {
            Name = name;
            Weight = weight;
            Age = age;
        }
    }
}
