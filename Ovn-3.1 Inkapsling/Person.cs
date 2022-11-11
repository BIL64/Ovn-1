using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ovn_3._1_Inkapsling
{
    internal class Person
    {
        private int age;
        private string fName = "";
        private string lName = "";
        private int height;
        private int weight;

        public int Height // Property Height.
        {
            get
            {
                if (fName == "" || lName == "") return 0; // 0 om förnamn eller efternamn saknas.
                else return height;
            }
            set { height = value; }
        }

        public int Weight // Property Weight.
        {
            get
            {
                if (fName == "" || lName == "") return 0; // 0 om förnamn eller efternamn saknas.
                else return weight;
            }
            set { weight = value; }
        }

        public string Forename // Property Forename.
        {
            get
            {
                if (fName.Length < 2 || fName.Length > 10) return "null"; // Null om valideringen misslyckas, annars värde.
                else return fName;
            }
            set
            {
                try
                {
                    fName = value;
                    Fname_test(value);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }   
        }

        public string Surname // Property Surname.
        {
            get
            {
                if (lName.Length < 3 || lName.Length > 15) return "null"; // Null om valideringen misslyckas, annars värde.
                else return lName;
            }
            set
            {
                try
                {
                    lName = value;
                    Sname_test(value);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }

        public int Age // Property Age.
        {
            get
            {
                if (age < 1 || fName == "" || lName == "") return 0; // Null om valideringen misslyckas eller om förnamn eller efternamn saknas.
                else return age;
            }
            set
            {
                try
                {
                    age = value;
                    Age_test(value);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }

        private bool Fname_test(string arg) // Returnerar falskt om validering misslyckas, annars sant. 
        {
            if (arg == "")
            {
                throw new ArgumentException("Can not be empty", "Forename");
            }
            if (arg.Length < 2 || arg.Length > 10)
            {
                throw new ArgumentException("To short or to long", "Forename");
            }
            else return true;
        }

        private bool Sname_test(string arg) // Returnerar falskt om validering misslyckas, annars sant.
        {
            if (arg == "")
            {
                throw new ArgumentException("Can not be empty", "Surname");
            }
            if (arg.Length < 3 || arg.Length > 15)
            {
                throw new ArgumentException("To short or to long", "Surname");
            }
            else return true;
        }

        private bool Age_test(int arg) // Returnerar falskt om validering misslyckas, annars sant.
        {
            if (arg < 1)
            {
                throw new ArgumentException("Can not be less than 1", "Age");
            }
            else return true;
        }
    }
}
