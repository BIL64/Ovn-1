using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn_2_2
{
    internal class Menu_Errtext // Lokal.
    {
        //ConsoleUI ui = new ConsoleUI(); // Är detta det smartaste sättet?
        private readonly IUI ui = new ConsoleUI(); // Ändrade till ett interface 221107, men det blev mer eller lika mycket kod för det.

        public void M_header()
        {
            Console.Clear();
            ui.WL("");
            Console.ForegroundColor = ConsoleColor.Yellow;
            ui.WL("*****BIO******");
            Console.ResetColor();
            ui.WL("ROYAL - MOTALA");
            Console.ForegroundColor = ConsoleColor.Yellow;
            ui.WL("*****BIO******");
            Console.ResetColor();
            ui.WL("");
        }

        public void M_main()
        {
            M_header();
            ui.WL("0)     <<<---  STÄNG CHECKEN");
            ui.WL("");
            ui.WL("1) -->>> *** CHECKA ROYALS PRISER *** <<<---");
            ui.WL("");
            ui.WL("2) Repeterar en text tio gånger");
            ui.WL("");
            ui.WL("3) Skriver ut det tredje ordet från en mening");
            ui.WL("");
            ui.W("Ange val: ");
        }

        public void M_sub()
        {
            M_header();
            ui.WL("1) En person - välj 1");
            ui.WL("");
            ui.WL("2) Flera personer - välj 2");
            ui.WL("");
            ui.WL("3) Återgå - välj 3");
            ui.WL("");
            ui.W("Ange val: ");
        }

        public void T_err()
        {
            ui.WL("");
            ui.W("Endast siffror (ej negativa) godtas...");
            ui.RL();
        }

        public void T_err03()
        {
            ui.WL("");
            ui.W("Godtagbara val är 0, 1, 2 eller 3...");
            ui.RL();
        }

        public void T_err13()
        {
            ui.WL("");
            ui.W("Godtagbara val är 1, 2 eller 3...");
            ui.RL();
        }
    }
}
