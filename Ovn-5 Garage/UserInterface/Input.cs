namespace Ovn_5_Garage.UserInterface
{
    public static class Input // Hanterar inmatning i typiska huvud eller submenyer, men med begränsningen 0-9.
    {
        public static bool Enter; // Flagga för uthopp med entertangenten direkt!

        public static char In(int max, bool quit) // Exvis Input.In(4, true) = 4 valalternativ och att man kan skriva "quit" för att hoppa ut.
        {                                         // Input.In(x, false) innebär att man kan använda entertangenten för att hoppa ut/återgå.        
            char value = ' ';
            bool display = true;

            while (display)
            {
                Console.Write("Enter choise: "); // T.o.m fältet för inmatningen kan läggas här inne. 

                try
                {
                    value = Console.ReadLine()[0]; //Tries to set input to the first char in an input line

                    string str = value.ToString(); // Inget ska väl kunna gå snett här?

                    if (str == "0" || str == "1" || str == "2" || str == "3" || str == "4" || str == "5" ||
                        str == "6" || str == "7" || str == "8" || str == "9")
                    {
                        if (int.Parse(str) < 0 || int.Parse(str) > max)
                        {
                            ClearForInput(0, 45, 2);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"   → Valid inputs is between 0 and {max}\a");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.SetCursorPosition(0, Console.CursorTop - 2); // Information om att man kan återgå med ett entertryck etc.
                            Console.ForegroundColor = ConsoleColor.Green;
                            if (quit) Console.WriteLine("    ☺ You can use ENTER for escaping but not always inside an" +
                                                        " input procedure. If so, use \"quit\"...");
                            else Console.WriteLine("    ☺ You can always use ENTER for escaping the input procedure...");
                            Console.ResetColor();
                            Console.SetCursorPosition(0, Console.CursorTop + 2);
                            display = false;
                        }
                    }
                    else
                    {
                        ClearForInput(0, 45, 2);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"   → Valid inputs is a number between 0 and {max}\a");
                        Console.ResetColor();
                    }
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    if (value == ' ') // Här hamnar de svåraste fallen eller när man trycker enter.
                    {
                        value = '↔'; // Ett unikt tecken förhindrar oavsiktlig aktivering av Enter.
                        display = false;
                    }
                    else
                    {
                        ClearForInput(0, 45, 2);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("    → Input is not valid! Try again...\a");
                        Console.ResetColor();
                    }
                }

            }

            if (value == '↔') Enter = true; else Enter = false; // Flagga för uthopp. Endast vid entertryck blir den sann, annars falsk.

            return value;
        }

        // Suddar en inmatning och skapar ett blink. Modifierad version.
        public static void ClearForInput(byte Xcol, byte X_step, byte Rows)
        {
            byte Yrow = (byte)Console.CursorTop;
            Console.SetCursorPosition(Xcol, Yrow - 2); // Startläget.

            for (int dex = 0; dex < Rows; dex++)
            {
                for (int index = 0; index < X_step; index++) // ░
                {
                    Console.Write(" "); // Generating whitespaces horizontally.
                }
                Console.WriteLine(""); // Stegar ned en rad.
            }
            Thread.Sleep(100); // Fördröjning.
            Console.SetCursorPosition(Xcol, Yrow - 2); // Hoppar tillbaks igen.
        }
    }
}