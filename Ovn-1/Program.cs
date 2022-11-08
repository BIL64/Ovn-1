using System;

namespace Ovn_1 // Av Björn Lindqvist 221101. För bättre version, se Ovn-1-2.
{
    internal class Program // Klasser = 0. Metoder = 2. Attribut: Två arrayer och räknare. Max 1001 anställda.
    {

        static void Main(string[] args)
        {
            bool display = true;
            string[] personalnamn = new string[1000]; // Array 1
            string[] personallon = new string[1000];  // Array 2
            int tal = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("PERSONALREGISTER");
                Console.WriteLine("1) Inskrivning av ny anställd.");
                Console.WriteLine("2) Lista alla anställda.");
                Console.WriteLine("3) Avsluta.");
                string val = Console.ReadLine();

                switch (val)
                {
                    case "1":
                        personalnamn[tal] = Inskrivning1();
                        personallon[tal] = Inskrivning2();
                        tal++; // Om mer än 1001 anställda matas in så krashar programmet!
                        break;
                    case "2":
                        Console.WriteLine("UTSKRIFT AV ANSTÄLLDA");
                        Console.WriteLine("");

                        for (int i = 0; i <= tal - 1; i++)
                        {
                            Console.WriteLine($"Anställd: {personalnamn[i]} ({i + 1} av {tal})");
                            Console.WriteLine($"Lön: {personallon[i]} kr."); // Bokstäver kan blandas med siffror.
                            Console.WriteLine("");
                        }

                        Console.ReadLine();
                        break;
                    case "3":
                        display = false;
                        break;
                }
            } while (display);

        }

        static string Inskrivning1()
        {
            Console.Write("Ditt namn: ");
            string pnamn = Console.ReadLine();
            return pnamn;
        }

        static string Inskrivning2()
        {
            Console.Write("Din lön (SEK): ");
            string plon = Console.ReadLine();
            return plon;
        }
    }
}