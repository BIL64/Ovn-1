namespace Ovn_5_Garage.UserInterface // Samlade menyer.
{
    internal class MenuUI
    {
        public static string Str { set; get; } = "MAXIMUM";
        public static int Cap { set; get; } = 0;
        public static int Inr { set; get; } = 0;

        public void M_header()
        {
            Console.Clear();
            CC.WL("");
            Console.ForegroundColor = ConsoleColor.Yellow;
            CC.WL($" {Str}  {Inr} of {Cap}");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Red;
            CC.WL("|#############################|");
            Console.ForegroundColor = ConsoleColor.Red;
            CC.W("|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            CC.W("  WELCOME TO MAXIMUM GARAGE  ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Red;
            CC.WL("|");
            Console.BackgroundColor = ConsoleColor.Gray;
            CC.WL("|##############=##############|");
            Console.BackgroundColor = ConsoleColor.Black;
            CC.W("  ");
            Console.BackgroundColor = ConsoleColor.Gray;
            CC.W("||");
            Console.BackgroundColor = ConsoleColor.Black;
            CC.W("          ");
            Console.BackgroundColor = ConsoleColor.Gray;
            CC.W("|#|");
            Console.BackgroundColor = ConsoleColor.Black;
            CC.W("          ");
            Console.BackgroundColor = ConsoleColor.Gray;
            CC.WL("||");
            Console.ResetColor();
            CC.WL("");
        }

        public void M_main()
        {
            M_header();
            CC.WL("1) Initiate the garage");
            CC.WL("");
            CC.WL("2) Add or Remove vehicle");
            CC.WL("");
            CC.WL("3) Print all, search or sort");
            CC.WL("");
            CC.WL("4) Popularize options");
            CC.WL("");
            CC.WL("0) Exit");
            CC.WL("");
        }

        public void M_sub1()
        {
            M_header();
            CC.WL("1) Add a vehicle");
            CC.WL("");
            CC.WL("2) Remove a vehicle");
            CC.WL("");
            CC.WL("0) Regress (or ENTER)");
            CC.WL("");
        }

        public void M_sub2()
        {
            M_header();
            CC.WL("1) Print all vehicles in the garage");
            CC.WL("");
            CC.WL("2) Search for everything");
            CC.WL("");
            CC.WL("3) Sort type of vehicles");
            CC.WL("");
            CC.WL("4) Search for a specific REG/Licens number (and Remove...)");
            CC.WL("");
            CC.WL("0) Regress (or ENTER)");
            CC.WL("");
        }

        public void M_sub3()
        {
            M_header();
            CC.WL("1) Popularize CityNorth with 8 different vehicles");
            CC.WL("");
            CC.WL("2) Popularize SkyPark with 1 airplane");
            CC.WL("");
            CC.WL("3) Add three different vehicles");
            CC.WL("");
            CC.WL("0) Regress (or ENTER)");
            CC.WL("");
        }
    }
}