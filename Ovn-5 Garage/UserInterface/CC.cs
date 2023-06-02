namespace Ovn_5_Garage.UserInterface
{
    public static class CC // CC = Console Class. Minimerar kod för prints o inputs i konsolmiljö, plus lite bling bling...
    {
        public static int R() // Ersätter "Console.Read()" = CC.R() int här, resten string.
        {
            return Console.Read();
        }

        public static string RL() // Ersätter "Console.ReadLine()" = CC.RL()
        {
            return Console.ReadLine()!;
        }

        public static void W(string input) // Ersätter "Console.Write()" = CC.W()
        {
            Console.Write(input);
        }

        public static void WL(string input) // Ersätter "Console.WriteLine()" = CC.WL()
        {
            Console.WriteLine(input);
        }

        public static void WR(string input) // Ersätter "Console.WriteLine()" = CC.WL() med röd textfärg (olika syften).
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(input);
            Console.ResetColor();
        }

        public static void WG(string input) // Ersätter "Console.WriteLine()" = CC.WL() med grön textfärg (olika syften).
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(input);
            Console.ResetColor();
        }

        public static void WY(string input) // Ersätter "Console.WriteLine()" = CC.WL() med gul textfärg (varningsmeddelanden).
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(input);
            Console.ResetColor();
        }

        public static void WB(string input) // Ersätter "Console.WriteLine()" = CC.WL() med blå textfärg (allt har gått bra).
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(input);
            Console.ResetColor();
        }

        // Suddar en inmatning och skapar ett blink. Gör så att markören backar tillbaks till ursprungspositionen efter varje inmatning.
        public static void ClearIn(int Xcol, int Yrow, byte X_step, byte Rows, short Offset, bool Line)
        {
            Console.SetCursorPosition(Xcol, Yrow); // Startläget.

            for (int dex = 0; dex < Rows; dex++)
            {
                for (int index = 0; index < X_step; index++) // ░ detta asciitecknet används för tester, så att man kan se ytan ClearIn orsakar. 
                {
                    if (index == X_step - 1 && Line) Console.Write("|"); else Console.Write(" "); // Generating whitespaces horizontally.
                }
                Console.WriteLine(""); // Stegar ned en rad.
            }
            Thread.Sleep(100); // Fördröjning. Medför att upprepade varningar med samma innehåll inte förblir omärkbara för ögat.
            Console.SetCursorPosition(Xcol, Yrow + Offset); // Hoppar tillbaks igen.
        }
    }
}