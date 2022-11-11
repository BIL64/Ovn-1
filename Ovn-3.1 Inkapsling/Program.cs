namespace Ovn_3._1_Inkapsling
{
    internal class Program // Av Björn Lindqvist 221110.
    {
        static void Main(string[] args)
        {
            Person test1 = new Person();
            PersonHandler test2 = new PersonHandler();

            do
            {
                // Person-testning:

                //Console.Clear();
                //Console.Write("Setting Age: ");
                //Console.WriteLine(test1.Age = 50);
                //Console.Write("Setting Height: ");
                //Console.WriteLine(test1.Height = 200);
                //Console.Write("Setting Weight: ");
                //Console.WriteLine(test1.Weight = 100);
                //Console.WriteLine("");
                //Console.Write("Getting Age: ");
                //Console.WriteLine(test1.Age);
                //Console.Write("Getting Height: ");
                //Console.WriteLine(test1.Height);
                //Console.Write("Getting Weight: ");
                //Console.WriteLine(test1.Weight);
                //Console.WriteLine("");

                //Console.ReadLine();

                //Console.Clear();
                //Console.Write("Setting Age: ");
                //Console.WriteLine(test1.Age = 50);
                //Console.Write("Setting Forename: ");
                //Console.WriteLine(test1.Forename = "Anders");
                //Console.Write("Setting Surname: ");
                //Console.WriteLine(test1.Surname = "Svensson");
                //Console.WriteLine("");
                //Console.Write("Getting Age: ");
                //Console.WriteLine(test1.Age);
                //Console.Write("Getting Forename: ");
                //Console.WriteLine(test1.Forename);
                //Console.Write("Getting Surname: ");
                //Console.WriteLine(test1.Surname);

                //Console.ReadLine();

                //Console.Clear();
                //Console.Write("Setting Age: ");
                //Console.WriteLine(test1.Age = 0);
                //Console.Write("Setting Forename: ");
                //Console.WriteLine(test1.Forename = "A");
                //Console.Write("Setting Surname: ");
                //Console.WriteLine(test1.Surname = "Sv");
                //Console.WriteLine("");
                //Console.Write("Getting Age: ");
                //Console.WriteLine(test1.Age);
                //Console.Write("Getting Forename: ");
                //Console.WriteLine(test1.Forename);
                //Console.Write("Getting Surname: ");
                //Console.WriteLine(test1.Surname);

                //Console.ReadLine();



                // PersonHandler-testning:

                Console.Clear();
                Console.WriteLine("Test av CreatePerson 1:");
                Console.WriteLine("CreatePerson: ");
                test2.CreatePerson(50, "Sture", "Wenzell", 200, 100);
 
                Console.Write("Getting Age: ");
                Console.WriteLine(test2.Age);
                Console.Write("Getting Forename: ");
                Console.WriteLine(test2.Forename);
                Console.Write("Getting Surname: ");
                Console.WriteLine(test2.Surname);
                Console.Write("Getting Height: ");
                Console.WriteLine(test2.Height);
                Console.Write("Getting Weight: ");
                Console.WriteLine(test2.Weight);

                Console.ReadLine();

                Console.Clear();
                Console.WriteLine("Test av CreatePerson 2 (age -3):");
                Console.WriteLine("CreatePerson: ");
                test2.CreatePerson(-3, "Peter", "Fors", 201.4, -10.2);

                Console.Write("Getting Age: ");
                Console.WriteLine(test2.Age);
                Console.Write("Getting Forename: ");
                Console.WriteLine(test2.Forename);
                Console.Write("Getting Surname: ");
                Console.WriteLine(test2.Surname);
                Console.Write("Getting Height: ");
                Console.WriteLine(test2.Height);
                Console.Write("Getting Weight: ");
                Console.WriteLine(test2.Weight);

                Console.ReadLine();

                Console.Clear();
                Console.WriteLine("Test av CreatePerson 2 (tomt förnamn):");
                Console.WriteLine("CreatePerson: ");
                test2.CreatePerson(33, "", "Lundström", 179, 86);

                Console.Write("Getting Age: ");
                Console.WriteLine(test2.Age);
                Console.Write("Getting Forename: ");
                Console.WriteLine(test2.Forename);
                Console.Write("Getting Surname: ");
                Console.WriteLine(test2.Surname);
                Console.Write("Getting Height: ");
                Console.WriteLine(test2.Height);
                Console.Write("Getting Weight: ");
                Console.WriteLine(test2.Weight);

                Console.ReadLine();

                Console.Clear();
                Console.WriteLine("I PersonHandler:");
                Console.WriteLine("CreatePerson: ");
                test2.CreatePerson(50, "Erik", "Ström", 182, 87);

                Console.Write("Getting Age: ");
                Console.WriteLine(test2.Age);
                Console.Write("Getting Forename: ");
                Console.WriteLine(test2.Forename);
                Console.Write("Getting Surname: ");
                Console.WriteLine(test2.Surname);
                Console.Write("Getting Height: ");
                Console.WriteLine(test2.Height);
                Console.Write("Getting Weight: ");
                Console.WriteLine(test2.Weight);

                Console.ReadLine();

                Console.Clear();
                Console.WriteLine("I Person:");
                Console.Write("Getting Age: ");
                Console.WriteLine(test1.Age);
                Console.Write("Getting Forename: ");
                Console.WriteLine(test1.Forename);
                Console.Write("Getting Surname: ");
                Console.WriteLine(test1.Surname);              
                Console.Write("Getting Height: ");
                Console.WriteLine(test1.Height);
                Console.Write("Getting Weight: ");
                Console.WriteLine(test1.Weight);
                Console.WriteLine("");

                Console.ReadLine();

                Console.Clear();
                Console.WriteLine("Setting/Getting i PersonHandler:");
                Console.Write("Setting Forename: ");
                Console.WriteLine(test2.Forename = "Arne");
                Console.Write("Setting Surname: ");
                Console.WriteLine(test2.Surname = "Larsson");
                Console.Write("Setting Age: ");
                Console.WriteLine(test2.Age = 27);
                Console.Write("Setting Height: ");
                Console.WriteLine(test2.Height = 192);
                Console.Write("Setting Weight: ");
                Console.WriteLine(test2.Weight = 70);
                Console.WriteLine("");
                Console.Write("Getting Forename: ");
                Console.WriteLine(test2.Forename);
                Console.Write("Getting Surname: ");
                Console.WriteLine(test2.Surname);
                Console.Write("Getting Age: ");
                Console.WriteLine(test2.Age);
                Console.Write("Getting Height: ");
                Console.WriteLine(test2.Height);
                Console.Write("Getting Weight: ");
                Console.WriteLine(test2.Weight);
                Console.WriteLine("");

                Console.ReadLine();

                Console.WriteLine("SetAge 55 på föregående i PersonHandler:");
                test2.SetAge(test1, 55);
                Console.Write("Getting Age: ");
                Console.WriteLine(test2.Age);
                Console.Write("Getting Forename: ");
                Console.WriteLine(test2.Forename);
                Console.Write("Getting Surname: ");
                Console.WriteLine(test2.Surname);
                Console.Write("Getting Height: ");
                Console.WriteLine(test2.Height);
                Console.Write("Getting Weight: ");
                Console.WriteLine(test2.Weight);
                Console.WriteLine("");

                Console.ReadLine();

            } while (true);
        }
    }
}