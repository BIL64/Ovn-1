using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn_3._3_Arv
{
    internal class Person : Animal, IPerson
    {
        public void Talk(string amal) // Själva utskriften.
        {
            Console.WriteLine("This " + amal + " named " + Outname());
            Console.WriteLine("weight " + Outweight() + " pounds and is " + Outage() + " years old.");
            Console.WriteLine("");
            Console.WriteLine("Attribute: " + Stats(amal));
            if (amal == "wolf") Console.WriteLine("This is the sound it makes: " + DoSound(amal) + ". I love this animal !!!");
            else Console.WriteLine("This is the sound it makes: " + DoSound(amal));
        }

        public Person(string name, int weight, int age) : base("null", 0, 0) // Denna var tvunget att inplementeras.
        {
            Name = name;
            Weight = weight;
            Age = age;
        }
    }
}
