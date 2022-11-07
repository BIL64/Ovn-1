using System;

namespace Ovn_2 // Av Björn Lindqvist 221104. Rev1: 1105 (0 kr för < 5 & > 100 år, kommentarer och antalet = 201).
{               // Ej fullständig (se Ovn-2-2).
    internal class Program
    {
        static void Main(string[] args)
        {
            bool bMenu = true;

            do
            {
                Meny(); // Huvudmenyn.
                string sVal = Console.ReadLine();

                switch (sVal)
                {
                    case "0":
                        bMenu = false;
                        break;
                    case "1":
                        do // Om felaktig inmatning görs så stannar man kvar i undermenyn.
                        {
                            UnderMeny();
                            string sUnderval = Console.ReadLine();
                            if (sUnderval != "1" && sUnderval != "2" && sUnderval != "3") EndastEtt_Tre();
                            else
                            {
                                Antal(sUnderval);
                                sVal = "0";
                            }
                        } while (sVal == "1");
                        break;
                    default: // Inmatningscheck.
                        EndastNoll_Ett();
                        break;
                }

            } while (bMenu);
        }

        static void Antal(string sVal) // Både val 1 (ensam) och 2 (flera) kommer hit först.
        {
            bool bTest = true;

            if (sVal == "1")
            {
                do
                {
                    Console.WriteLine("");
                    Console.Write("Ange din ålder (ENTER för att återgå): "); // Åldern för en ensam besökare.
                    string sSvar = Console.ReadLine();
                    if (sSvar != "")
                    {
                        try // Inmatningscheck och utresultat.
                        {
                            uint uiAge = uint.Parse(sSvar);
                            MenyRubrik();
                            if (uiAge < 5) Console.WriteLine("Gratis!"); // Prissättning för en ensam besökare.
                            else if (uiAge < 20 && uiAge >= 5) Console.WriteLine("Ungdomspris: 80kr.");
                            else if (uiAge > 64 && uiAge <= 100) Console.WriteLine("Pensonärspris: 90kr.");
                            else if (uiAge > 100) Console.WriteLine("Gratis!");
                            else Console.WriteLine("Standardpris: 120kr.");
                            Console.ReadLine();
                            bTest = false;
                        }
                        catch
                        {
                            EndastSiffror();
                        }
                    }
                    else bTest = false;
                } while (bTest);
            }
            if (sVal == "2") Flera();
        }

        static void Flera() // Första instansen om man väljer fler än en besökare.
        {
            bool bTest = true;

            do
            {
                Console.WriteLine("");
                Console.Write("Hur många är ni? (ENTER för att återgå): "); // Första inmatning för flera besökare gäller antalet. 
                string sSvar = Console.ReadLine();                          // Man kan återgå till huvudmenyn om man trycker
                if (sSvar != "" && sSvar != "0" && sSvar != "1")            // enter direkt eller anger ett för lågt tal.
                {
                    try // Inmatningscheck.
                    {
                        uint uiAntal = uint.Parse(sSvar);
                        if (uiAntal > 200) uiAntal = 200; // Om högre antal än 200 matas in sätts 200, för att unvika krash.
                        KalkylFlera(uiAntal);
                        bTest = false;
                    }
                    catch
                    {
                        EndastSiffror();
                    }
                }
                else bTest = false;
            } while (bTest);
        }

        static void KalkylFlera(uint uiAntal) // Den andra inmatningen för flera besökare gäller åldern för var och en.
        {
            uint[] uiSumma = new uint[200]; // Max 201 beökare.
            uint uiRak = 0;
            bool bTest = true;

            do
            {
                Console.WriteLine("");
                if (uiRak == 200) Console.Write($"Ange ålder för person {uiRak + 1} MAXANTAL!: "); // Varnar för att 200 är det högsta antalet.
                else Console.Write($"Ange ålder för person {uiRak + 1} (ENTER för att återgå): "); // Man kan återgå till huvudmenyn om man
                string sSvar = Console.ReadLine();                                                 // trycker enter direkt.
                if (sSvar != "")
                {
                    try // Inmatningscheck.
                    {
                        uint uiAge = uint.Parse(sSvar);
                        if (uiAge < 5) uiSumma[uiRak] = 0; // Prissättningen lagras i en uint-array för varje person.
                        else if (uiAge < 20 && uiAge >= 5) uiSumma[uiRak] = 80;
                        else if (uiAge > 64 && uiAge <= 100) uiSumma[uiRak] = 90;
                        else if (uiAge > 100) uiSumma[uiRak] = 0;
                        else uiSumma[uiRak] = 120;
                        uiRak++;
                        if (uiRak > uiAntal - 1) KalkylResultat(uiSumma, uiAntal);
                    }
                    catch
                    {
                        EndastSiffror();
                    }
                }
                else bTest = false;
            } while (bTest && uiRak < uiAntal); // Två olika villkor styr om uthopp bör ske.
        }

        static void KalkylResultat(uint[] uiSumma, uint uiAntal) // Utresultatet för flera besökare (sista).
        {
            uint uiTotal = 0;

            for (int i = 0; i <= uiAntal - 1; i++) // Arrayen från KalkylFlera länkas hit för summaberäkningen. 
            {
                uiTotal += uiSumma[i];
            }

            MenyRubrik();
            Console.WriteLine($"Antal personer: {uiAntal}");
            if (uiTotal == 0) Console.WriteLine($"Samt totalkostnad för hela sällskapet: Gratis!"); // Fixar "gratis" om 0kr?
            else Console.WriteLine($"Samt totalkostnad för hela sällskapet: {uiTotal}kr.");
            Console.ReadLine();
        }

        static void MenyRubrik() // Alla menykonstruktioner börjar här (förutom utresultaten).
        {
            Console.Clear();
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*****BIO******");
            Console.ResetColor();
            Console.WriteLine("ROYAL - MOTALA");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*****BIO******");
            Console.ResetColor();
            Console.WriteLine("");
        }

        static void Meny()
        {
            MenyRubrik();
            Console.WriteLine("0)     <<<---  STÄNG CHECKEN");
            Console.WriteLine("");
            Console.WriteLine("1) -->>> *** CHECKA ROYALS PRISER *** <<<---");
            Console.WriteLine("");
            Console.Write("Ange val: ");
        }

        static void UnderMeny()
        {
            MenyRubrik();
            Console.WriteLine("1) En person - välj 1");
            Console.WriteLine("");
            Console.WriteLine("2) Flera personer - välj 2");
            Console.WriteLine("");
            Console.WriteLine("3) Återgå - välj 3");
            Console.WriteLine("");
            Console.Write("Ange val: ");
        }

        static void EndastNoll_Ett() // Felmeddelanden börjar här.
        {
            Console.WriteLine("");
            Console.Write("Godtagbara val är 0 eller 1...");
            Console.ReadLine();
        }

        static void EndastEtt_Tre()
        {
            Console.WriteLine("");
            Console.Write("Godtagbara val är 1, 2 eller 3...");
            Console.ReadLine();
        }

        static void EndastSiffror()
        {
            Console.WriteLine("");
            Console.Write("Endast siffror (ej negativa) godtas...");
            Console.ReadLine();
        }
    }
}