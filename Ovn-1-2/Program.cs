using System;

namespace Ovn_1_2
{
    internal class Program  // Av Björn Lindqvist 221102. Rev1: 1103 (Arrayerna har byts mot en List<string> och nya menyer plus en metod).
    {
        static void Main(string[] args)
        {
            List<string> employee_list = new List<string>(); // List<string> (det var arrayer förut).
            employee_list.Clear(); // Nollställer listan till att börja med (väldigt ovanlig åtgärd i verkligheten).

            do
            {
                MenuBody();
                string val = Console.ReadLine();

                switch (val)
                {
                    case "1":
                        string str_name = Inscript_N();
                        string str_sal = Inscript_S();
                        employee_list.Add($"Anställd: {str_name}, lön {str_sal} kr."); // Adderar listan med enbart strängvariabler.
                        break;
                    case "2":
                        foreach (var item in employee_list)
                        {
                            Console.WriteLine(item);
                        }
                        Console.ReadLine();
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;
                }

            } while (true);
        }

        static void MenuBody() // Fristående huvudmeny.
        {
            Console.Clear();
            Console.WriteLine("PERSONALREGISTER");
            Console.WriteLine("1) Inskrivning av ny anställd.");
            Console.WriteLine("2) Lista alla anställda.");
            Console.WriteLine("3) Avsluta.");
        }

        static string Inscript_N()
        {
            Console.Write("Den anställdes namn: ");
            string name = Console.ReadLine();
            return name;
        }

        static string Inscript_S()
        {
            Console.Write("Den anställdes lön (SEK): ");
            string sal = Console.ReadLine();
            return sal;
        }
    }
}