using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ovn_3._1_Inkapsling
{
    internal class PersonHandler
    {
        private string fname = "";
        private string lname = "";
        private int age;
        private double height;
        private double weight;

        public void SetAge(Person pers, int age)
        {
           try
            {
                if (!Age_test(age)) age = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            this.age = age;
        }

        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            try
            {
                if (!Fname_test(fname)) fname = "null";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            this.fname = fname;

            try
            {
                if (!Sname_test(lname)) lname = "null";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            this.lname = lname;

            try
            {
                if (!Age_test(age) || fname == "" || lname == "") age = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            this.age = age;

            try
            {
                if (fname == "" || lname == "") height = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            this.height = height;

            try
            {
                if (fname == "" || lname == "") weight = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            this.weight = weight;

            Person pers = new Person(); // Ny instans av Person och reurnerar den ???

            pers.Forename = fname;
            pers.Surname = lname;
            pers.Age = age;
            pers.Height = (int) height;
            pers.Weight = (int) weight;

            return pers;
        }

        public double Height // Property Height.
        {
            get
            {
                if (fname == "" || lname == "") return 0; // 0 om förnamn eller efternamn saknas.
                else return height;
            }
            set { height = value; }
        }

        public double Weight // Property Weight.
        {
            get
            {
                if (fname == "" || lname == "") return 0; // 0 om förnamn eller efternamn saknas.
                else return weight;
            }
            set { weight = value; }
        }

        public string Forename // Property Forename.
        {
            get
            {
                if (fname.Length < 2 || fname.Length > 10) return "null"; // Null om valideringen misslyckas, annars värde.
                else return fname;
            }
            set
            {
                try
                {
                    fname = value;
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
                if (lname.Length < 3 || lname.Length > 15) return "null"; // Null om valideringen misslyckas, annars värde.
                else return lname;
            }
            set
            {
                try
                {
                    lname = value;
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
                if (age < 1 || fname == "" || lname == "") return 0; // Null om valideringen misslyckas eller om förnamn eller efternamn saknas.
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

        private bool Fname_test(string arg) // Validering av Forename. 
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

        private bool Sname_test(string arg) // Validering av Surname.
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

        private bool Age_test(int arg) // Validering av Age.
        {
            if (arg < 1)
            {
                throw new ArgumentException("Can not be less than 1", "Age");
            }
            else return true;
        }
    }
}
