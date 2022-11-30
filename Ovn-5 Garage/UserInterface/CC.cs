namespace Ovn_5_Garage.UserInterface
{
    public static class CC // CC = Console Class. Minimerar kod för prints o inputs i konsolmiljö, plus lite bling bling...
    {
        public static int R() // int här, resten string.
        {
            return Console.Read();
        }

        public static string RL()
        {
            return Console.ReadLine();
        }

        public static void W(string input)
        {
            Console.Write(input);
        }

        public static void WL(string input)
        {
            Console.WriteLine(input);
        }

        public static void WR(string input)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(input);
            Console.ResetColor();
        }

        public static void WG(string input)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(input);
            Console.ResetColor();
        }

        public static void WY(string input)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(input);
            Console.ResetColor();
        }

        public static void WB(string input)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(input);
            Console.ResetColor();
        }

        // Suddar en inmatning och skapar ett blink.
        public static void ClearIn(int Xcol, int Yrow, byte X_step, byte Rows, short Offset, bool Line)
        {
            Console.SetCursorPosition(Xcol, Yrow); // Startläget.

            for (int dex = 0; dex < Rows; dex++)
            {
                for (int index = 0; index < X_step; index++) // ░
                {
                    if (index == X_step - 1 && Line) Console.Write("|"); else Console.Write(" "); // Generating whitespaces horizontally.
                }
                Console.WriteLine(""); // Stegar ned en rad.
            }
            if (Line) Thread.Sleep(100); // Fördröjning.
            Console.SetCursorPosition(Xcol, Yrow + Offset); // Hoppar tillbaks igen.
        }
    }
}