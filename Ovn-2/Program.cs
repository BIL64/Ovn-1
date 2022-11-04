using System;

namespace Ovn_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool bMenu = true;

            do
            {
                Meny();
                string sVal = Console.ReadLine();

                switch (sVal)
                {
                    case "0":
                        bMenu = false;
                        break;
                    case "1":
                        do
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
                    default:
                        EndastNoll_Ett();
                        break;
                }

            } while (bMenu);
        }

        static void Antal(string sVal)
        {
            bool bTest = true;

            if (sVal == "1")
            {
                do
                {
                    Console.WriteLine("");
                    Console.Write("Ange din ålder (ENTER för att återgå): ");
                    string sSvar = Console.ReadLine();
                    if (sSvar != "")
                    {
                        try
                        {
                            uint uiAge = uint.Parse(sSvar);
                            MenyRubrik();
                            if (uiAge < 20) Console.WriteLine("Ungdomspris: 80kr.");
                            else if (uiAge > 64) Console.WriteLine("Pensonärspris: 90kr.");
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

        static void Flera()
        {
            bool bTest = true;

            do
            {
                Console.WriteLine("");
                Console.Write("Hur många är ni? (ENTER för att återgå): ");
                string sSvar = Console.ReadLine();
                if (sSvar != "" && sSvar != "0" && sSvar != "1")
                {
                    try
                    {
                        uint uiAntal = uint.Parse(sSvar);
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

        static void KalkylFlera(uint uiAntal)
        {
            uint[] uiSumma = new uint[1000];
            uint uiRak = 0;
            bool bTest = true;

            do
            {
                Console.WriteLine("");
                Console.Write($"Ange ålder för person {uiRak + 1} (ENTER för att återgå): ");
                string sSvar = Console.ReadLine();
                if (sSvar != "")
                {
                    try
                    {
                        uint uiAge = uint.Parse(sSvar);
                        if (uiAge < 20) uiSumma[uiRak] = 80;
                        else if (uiAge > 64) uiSumma[uiRak] = 90;
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
            } while (bTest && uiRak < uiAntal);
        }

        static void KalkylResultat(uint[] uiSumma, uint uiAntal)
        {
            uint uiTotal = 0;

            for (int i = 0; i <= uiAntal - 1; i++)
            {
                uiTotal += uiSumma[i];
            }

            MenyRubrik();
            Console.WriteLine($"Antal personer: {uiAntal}");
            Console.WriteLine($"Samt totalkostnad för hela sällskapet: {uiTotal}kr.");
            Console.ReadLine();
        }

        static void MenyRubrik()
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

        static void EndastNoll_Ett()
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
            Console.Write("Endast siffror godtas...");
            Console.ReadLine();
        }
    }
}