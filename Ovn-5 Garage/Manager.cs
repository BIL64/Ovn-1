using Ovn_5_Garage.UserInterface;

namespace Ovn_5_Garage // Manager sköter enbart valen.
{
    internal class Manager
    {
        readonly MenuUI Menu = new(); // Grafik med menyer och submenyer.
        readonly Handler Hand = new(); // Manager bollar över alla problem till Handler.

        public void Run()
        {
            Initialize();
        }

        private void Initialize()
        {
            do
            {
                Menu.M_main(); // Huvudmeny.
                switch (Input.In(4, false)) // Input sköter inmatning.
                {
                    case '0': // Exit.
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    case '1': // Initiera garaget.
                        Hand.Choice_NewGarage();
                        break;
                    case '2': // Lägga till eller ta bort fordon.
                        do
                        {
                            Menu.M_sub1(); // Meny för fylla/tömma.
                            switch (Input.In(2, true))
                            {
                                case '0': // Exit.
                                    Input.Enter = true;
                                    break;
                                case '1': // Lägg till fordon.
                                    Hand.Choice_Add();
                                    break;
                                case '2': // Ta bort fordon.
                                    Hand.Choice_Remove();
                                    break;
                            }
                        } while (!Input.Enter); // Så länge ingen tryckt på enter.
                        break;
                    case '3': // Till sökmeny.
                        do
                        {
                            Menu.M_sub2(); // Meny för garagesökningar.
                            switch (Input.In(4, false))
                            {
                                case '0': // Exit.
                                    Input.Enter = true;
                                    break;
                                case '1': // Skriv ut alla fordon.
                                    Hand.Choice_ListAll();
                                    break;
                                case '2': // Sök på allt.
                                    Hand.Choice_Search();
                                    break;
                                case '3': // Lista alla efter fordonstyp.
                                    Hand.Choice_ListType();
                                    break;
                                case '4': // Sök efter regnumret.
                                    Hand.Choice_SearchRegNumber();
                                    break;
                            }
                        } while (!Input.Enter);
                        break;
                    case '4': // Valmöjligheter (populera garage med fordon).
                        do
                        {
                            Menu.M_sub3(); // Meny för populering.
                            switch (Input.In(2, false))
                            {
                                case '0': // Exit.
                                    Input.Enter = true;
                                    break;
                                case '1': // Populationsalternativ 1.
                                    Hand.Choice_Populate1();
                                    break;
                                case '2': // Populationsalternativ 2.
                                    Hand.Choice_Populate2();
                                    break;
                            }
                        } while (!Input.Enter);
                        break;
                }
            } while (true);
        }
    }
}
