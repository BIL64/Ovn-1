using System;

namespace Ovn_2_2 // Av Björn Lindqvist 221104. Rev2: 1106 (Utökad enligt sidan 2 och två tillagda klasser).
{
    internal class Program
    {
        //static ConsoleUI ui = new ConsoleUI(); // Denna klass tar hand om alla Console.Read/Write kombinationer (ui.R, ui.RL, ui.W, ui.WL).
        static IUI ui = new ConsoleUI(); // Ändrade till ett interface 221107.
        static Menu_Errtext merrt = new Menu_Errtext(); // Denna klass sköter menyer och felmeddelanden (merrt).

        static void Main(string[] args)
        {
            bool bMenu = true;

            do
            {
                merrt.M_main();
                string sVal = ui.RL();

                switch (sVal)
                {
                    case "0":
                        bMenu = false;
                        break;
                    case "1":
                        do // Om felaktig inmatning görs så stannar man kvar i submenyn.
                        {
                            merrt.M_sub();
                            string sUnderval = ui.RL();
                            if (sUnderval != "1" && sUnderval != "2" && sUnderval != "3") merrt.T_err13();
                            else
                            {
                                Antal(sUnderval);
                                sVal = "0";
                            }
                        } while (sVal == "1");
                        break;
                    case "2":
                        Repeterar(); // Nytillkommen metod - repeterar text tio gånger.
                        break;
                    case "3":
                        TredjeOrdet(); // Nytillkommen metod - printar ut tredje ordet.
                        break;
                    default: // Inmatningscheck.
                        merrt.T_err();
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
                    ui.WL("");
                    ui.W("Ange din ålder (ENTER för att återgå): "); // Åldern för en ensam besökare.
                    string sSvar = ui.RL();
                    if (sSvar != "")
                    {
                        try // Inmatningscheck och utresultat.
                        {
                            uint uiAge = uint.Parse(sSvar);
                            merrt.M_header();
                            if (uiAge < 5) ui.WL("Gratis!"); // Prissättning för en ensam besökare.
                            else if (uiAge < 20 && uiAge >= 5) ui.WL("Ungdomspris: 80kr.");
                            else if (uiAge > 64 && uiAge <= 100) ui.WL("Pensonärspris: 90kr.");
                            else if (uiAge > 100) ui.WL("Gratis!");
                            else ui.WL("Standardpris: 120kr.");
                            ui.RL();
                            bTest = false;
                        }
                        catch
                        {
                            merrt.T_err();
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
                ui.WL("");
                ui.W("Hur många är ni? (ENTER för att återgå): "); // Första inmatning för flera besökare gäller antalet. 
                string sSvar = ui.RL();                            // Man kan återgå till huvudmenyn om man trycker
                if (sSvar != "" && sSvar != "0" && sSvar != "1")   // enter direkt eller anger ett för lågt tal.
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
                        merrt.T_err();
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
                ui.WL("");
                if (uiRak == 200) ui.W($"Ange ålder för person {uiRak + 1} MAXANTAL!: "); // Varnar för att 200 är det högsta antalet.
                else ui.W($"Ange ålder för person {uiRak + 1} (ENTER för att återgå): "); // Man kan återgå till huvudmenyn om man
                string sSvar = ui.RL();                                                   // trycker enter direkt.
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
                        merrt.T_err();
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

            merrt.M_header();
            ui.WL($"Antal personer: {uiAntal}");
            if (uiTotal == 0) ui.WL($"Samt totalkostnad för hela sällskapet: Gratis!"); // Fixar "gratis" om 0kr?
            else ui.WL($"Samt totalkostnad för hela sällskapet: {uiTotal}kr.");
            ui.RL();
        }

        static void Repeterar() // Repeterar text tio gånger.
        {
            bool display = true;

            ui.WL("");
            do
            {
                ui.WL("");
                ui.WL("Skriv en valfri text (ENTER för att återgå): ");
                string sText = ui.RL();
                ui.WL("");
                if (sText != "")
                {
                    for (int i = 0; i < 10; i++)
                    {
                        if (i != 9) ui.W($"{i + 1}. {sText}, ");
                        else ui.W($"{i + 1}. {sText}.");
                    }
                    ui.RL();
                } else display = false;

            } while (display); // Utförs till man trycker enter.
        }

        static void TredjeOrdet() // Printar ut det tredje ordet.
        {
            bool display = true;

            ui.WL("");
            do
            {
                ui.WL("Skriv en mening med minst tre ord (ENTER för att återgå): ");
                string sText = ui.RL();
                ui.WL("");
                if (sText != "")
                {
                    string[] aArrayen = sText.Split(' ');

                    if (aArrayen.Length >= 3)
                    {
                        ui.WL(aArrayen[2]);
                        ui.RL();
                    } else ui.WL("Minst tre ord...");

                } else display = false;

            } while (display); // Utförs till man trycker enter.
        }
    }
}