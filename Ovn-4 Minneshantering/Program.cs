using System.Diagnostics;
using static System.Reflection.Metadata.BlobBuilder;

namespace Ovn_4_Minneshantering // Av Björn Lindqvist 221117.
{
    internal class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Please navigate through the menu by inputting the number\n(1, 2, 3 ,4, 5, 6, 0) of your choice\n"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. Check Paranthesis"
                    + "\n5. Recursive"
                    + "\n6. Iterative"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.WriteLine("Please enter some input!");
                    Console.ReadLine();
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    case '5':
                        RecursiveSub();
                        break;
                    case '6':
                        IterativeSub();
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (1, 2, 3, 4, 5, 6 or 0)");
                        Console.ReadLine();
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            List<string> theList = new List<string>();

            bool display = true;

            while (display)
            {
                Console.Clear();
                Console.WriteLine("EXAMINE A LIST\n(1 or 0) of your choice\n"
                    + "\n1. Start to add or remove strings to a list"
                    + "\n0. Exit Examine list");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        theList.Clear();
                        Console.WriteLine("\nPress ENTER for exit\n");
                        Console.WriteLine("Add someting to the list by type \"+\" before a string (like +Adam or + alone)");
                        Console.WriteLine("Remove something to the list by type \"-\" before a string (like -Adam or - alone)\n");
                        do
                        {
                            Console.Write("add/remove in the list: ");
                            string str = Console.ReadLine();
                            if (str != "") // Fixar uthopp med Enter (tom sträng).
                            {
                                if (str.Substring(0, 1) == "+" || str.Substring(0, 1) == "-")
                                {
                                    // Adderar eller tar bort från listan.
                                    if (str.Substring(0, 1) == "+" && str.Length > 1) theList.Add(str.Substring(1));
                                    else if (str == "+") theList.Add("+");

                                    if (str.Substring(0, 1) == "-" && str.Length > 1) theList.Remove(str.Substring(1));
                                    else if (str == "-") theList.Remove("+");

                                    Console.WriteLine("\nCapacity: " + theList.Capacity); // Uppgiftens nyckelvärdet (bestäms av List).
                                    Console.WriteLine("Count   : " + theList.Count); // Antalet element i listan.
                                    Console.Write("List content: ");

                                    foreach (var item in theList) // Listan skrivs ut varje gång efter att man matat in eller tagit bort.
                                    {
                                        Console.Write(item + ", ");
                                    }
                                    Console.WriteLine("\n");
                                }
                                else
                                {
                                    // Aktiveras endast om man matar in andra tecken än + eller -
                                    Console.WriteLine("\nThe string must start with \"+\" or \"-\", but + / - alone");
                                    Console.WriteLine("will add or remove a \"+\".\n");
                                }
                            }
                            else
                            {
                                Console.Clear();
                                break;
                            }
                        } while (true);
                        break;
                    case '0':
                        display = false;
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (1 or 0)");
                        Console.ReadLine();
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            Queue<string> theQueue = new Queue<string>();

            bool display = true;

            while (display)
            {
                Console.Clear();
                Console.WriteLine("EXAMINE A FIFO QUEUE\n(1 or 0) of your choice\n"
                    + "\n1. Start to add a string to a queue or decrease it"
                    + "\n0. Exit Examine queue");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        theQueue.Clear();
                        Console.WriteLine("\nPress ENTER for exit\n");
                        Console.WriteLine("Add something to the queue by type \"+\" before a string (like +Adam or + alone)");
                        Console.WriteLine("Decrease (FIFO) the queue by type \"-\" or before a string.\n");
                        do
                        {
                            Console.Write("add/decrease the queue: ");
                            string str = Console.ReadLine();
                            if (str != "") // Fixar uthopp med Enter (tom sträng).
                            {
                                if (str.Substring(0, 1) == "+" || str.Substring(0, 1) == "-")
                                {
                                    // Adderar eller minskar kön.
                                    if (str.Substring(0, 1) == "+" && str.Length > 1) theQueue.Enqueue(str.Substring(1));
                                    else if (str == "+") theQueue.Enqueue("+");

                                    if (str.Substring(0, 1) == "-") theQueue.Dequeue();

                                    Console.WriteLine("\nCapacity: " + theQueue.Count); // Kapaciteten är hela tiden                                                                                     
                                    Console.WriteLine("Count   : " + theQueue.Count);   // detsamma som antalet element.
                                    Console.Write("Queue content: ");

                                    foreach (var item in theQueue) // Kön skrivs ut varje gång efter att man matat in eller tagit bort.
                                    {
                                        Console.Write(item + ", ");
                                    }
                                    Console.WriteLine("\n");
                                }
                                else
                                {
                                    // Aktiveras endast om man matar in andra tecken än + eller -
                                    Console.WriteLine("\nThe string must start with \"+\" or \"-\", but + / - alone");
                                    Console.WriteLine("will add a + or decrease (as FIFO) the queue\n");
                                }
                            }
                            else
                            {
                                Console.Clear();
                                break;
                            }
                        } while (true);
                        break;
                    case '0':
                        display = false;
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (1 or 0)");
                        Console.ReadLine();
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            bool display = true;

            while (display)
            {
                Console.Clear();
                Console.WriteLine("EXAMINE A FILO QUEUE (STACK)\n(1 or 0) of your choice\n"
                    + "\n1. Start to add a string"
                    + "\n0. Exit Examine queue");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        do
                        {
                            Console.WriteLine();
                            Console.Write("Add string (ENTER för exit): ");
                            string str = Console.ReadLine();
                            if (str != "") // Fixar uthopp med Enter (tom sträng).
                            {
                                // Reverserar strängen.
                                Char[] chars = str.ToCharArray();
                                Array.Reverse(chars);

                                Console.WriteLine();
                                Console.Write("Stack princip: " + str + " → ");

                                foreach (var item in chars) // Skriver ut omvänd sträng.
                                {
                                    Console.Write(item);
                                }

                                Console.ReadLine();
                            }
                            else
                            {
                                Console.Clear();
                                break;
                            }
                        } while (true);
                        break;
                    case '0':
                        display = false;
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (1 or 0)");
                        Console.ReadLine();
                        break;
                }
            }
        }

        static void CheckParanthesis()
        {
            bool display = true;

            while (display)
            {
                List<char> rb_list = new List<char>(); // Lista för round brackets.
                List<char> sb_list = new List<char>(); // Lista för square brackets.
                List<char> cb_list = new List<char>(); // Lista för curly brackets.

                List<char> even_list = new List<char>(); // Lista för jämna index.
                List<char> odd_list = new List<char>(); // Lista för udda index.

                Console.Clear();
                Console.WriteLine("CHECK PARANTHESIS\n(1 or 0) of your choice\n"
                    + "\n1. Start to add a string with paranthesis"
                    + "\n0. Exit Check paranthesis");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        do
                        {
                            bool rb_flag = false; // Symetriflaggor.
                            bool sb_flag = false;
                            bool cb_flag = false;

                            //bool b_swap = false; // Flagga för bakoframvända parenteser typ )(, ][ eller }{.

                            bool nested = false; // Flagga för nästlade parenteser.

                            int tal1 = 0; // Hjälptal för test.
                            int tal2 = 0;
                            int rak = 0;
                            rb_list.Clear();
                            sb_list.Clear();
                            cb_list.Clear();
                            even_list.Clear();
                            odd_list.Clear();
                            Console.WriteLine();
                            Console.Write("Add string (ENTER för exit): ");
                            string str = Console.ReadLine();

                            if (str != "") // Fixar uthopp med Enter (tom sträng).
                            {
                                Char[] chars = str.ToCharArray(); // Gör först en array av strängen.

                                for (int i = 0; i < str.Length; i++) // Här börjar laddningen av tre listor av det som finns i str.
                                {
                                    if (chars[i] == '(' || chars[i] == ')') // Round brackets.
                                    {
                                        if (chars[i] == '(') rb_list.Add('('); else rb_list.Add(')'); // Laddar cb_list.
                                    }

                                    if (chars[i] == '[' || chars[i] == ']') // Square brackets.
                                    {
                                        if (chars[i] == '[') sb_list.Add('['); else sb_list.Add(']'); // Laddar sb_list.
                                    }

                                    if (chars[i] == '{' || chars[i] == '}') // Curly brackets.
                                    {
                                        if (chars[i] == '{') cb_list.Add('{'); else cb_list.Add('}'); // Laddar cb_list.
                                    }
                                }

                                int rb_count = rb_list.Count; // Här börjar check av symetri.
                                int sb_count = sb_list.Count; // <-- antalet element i listorna.
                                int cb_count = cb_list.Count;

                                foreach (var item in rb_list) // Testar spegelsymetrin för rundparenteser.
                                {
                                    if (item == '(') tal1 += 1;
                                    if (item == ')') tal2 += 1;
                                }
                                if (tal1 != tal2) rb_flag = true;

                                tal1 = 0;
                                tal2 = 0;
                                foreach (var item in sb_list) // Testar spegelsymetrin för hakparenteser.
                                {
                                    if (item == '[') tal1 += 1;
                                    if (item == ']') tal2 += 1;
                                }
                                if (tal1 != tal2) sb_flag = true;

                                tal1 = 0;
                                tal2 = 0;
                                foreach (var item in cb_list) // Testar spegelsymetrin för klamrar.
                                {
                                    if (item == '{') tal1 += 1;
                                    if (item == '}') tal2 += 1;
                                }
                                if (tal1 != tal2) cb_flag = true; // Här slutar check av symetri.

                                tal1 = 0; // Här börjar check av nästlade parenteser.
                                tal2 = 0; // Larmar även när parenteserna är ojämnt fördelade (osymetetriskt).
                                rak = 0;
                                rb_list.Clear();
                                for (int i = 0; i < str.Length; i++) // Laddar om rb_list med alla parenteser.
                                {
                                    char ch = chars[i];
                                    if (ch == '(' || ch == ')' || ch == '[' || ch == ']' || ch == '{' || ch == '}')
                                    {
                                        rb_list.Add(ch);
                                    }
                                }
                                // rb_list innehåller nu förutom vanliga parenteser även hak- och klammerparenteser.

                                foreach (var item in rb_list) // Laddar två nya listor med jämna- respektive ojämna index.
                                {                             // Det är det som är hemligheten. Jag kom på det själv.
                                    if (rak % 2 == 0) even_list.Add(item); else odd_list.Add(item);
                                    rak++;
                                }

                                foreach (var item in even_list) // Innehållet i jämn-listan omvandlas till tal beroende på tecken.
                                {
                                    if (item == '(' || item == ')') tal1 += 1;
                                    if (item == '[' || item == ']') tal1 += 2;
                                    if (item == '{' || item == '}') tal1 += 3;
                                }

                                foreach (var item in odd_list) // Innehållet i udd-listan omvandlas till tal beroende på tecken.
                                {
                                    if (item == '(' || item == ')') tal2 += 1;
                                    if (item == '[' || item == ']') tal2 += 2;
                                    if (item == '{' || item == '}') tal2 += 3;
                                }
                                if (tal1 != tal2 && tal1 > 1 && tal2 > 1) nested = true; // Om talen är olika så kan den vara nästlad.

                                Console.WriteLine();
                                if (rb_count + sb_count + cb_count != 0)
                                {
                                    if (rb_count > 0)
                                    {
                                        if (rb_flag) Console.WriteLine("(<> Round brackets are NOT shapely!");
                                        else Console.WriteLine("(<>) Round brackets are *shapely*");
                                    }
                                    if (sb_count > 0)
                                    {
                                        if (sb_flag) Console.WriteLine("[<> Square brackets are NOT shapely!");
                                        else Console.WriteLine("[<>] Square brackets are *shapely*");
                                    }
                                    if (cb_count > 0)
                                    {
                                        if (cb_flag) Console.WriteLine("{<> Curly brackets are NOT shapely!");
                                        else Console.WriteLine("{<>} Curly brackets are *shapely*");
                                    }
                                    if (nested)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("There is brackets that can be classified as NESTED...");
                                    }
                                    if (BrackRevOrder.Test(rb_list)) // Anropar klass.
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("Some brackets may be REVERSE order.");
                                    }
                                }
                                else Console.WriteLine("No brackets find.");
                            }
                            else
                            {
                                Console.Clear();
                                break;
                            }
                        } while (true);
                        break;
                    case '0':
                        display = false;
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (1 or 0)");
                        Console.ReadLine();
                        break;
                }
            }
        }

        /// <summary>
        /// Examines  RecursiveEven(int n)
        /// </summary>
        static void RecursiveSub()
        {
            bool display = true;

            while (display)
            {
                Console.Clear();
                Console.WriteLine("EXAMINE RECURSIVE ODD EVENT\n(1 or 0) of your choice\n"
                    + "\n1. Start test of recursive n:th"
                    + "\n2. Start test of fibonacci sequence"
                    + "\n0. Exit Examine odd event");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        do
                        {
                            Console.WriteLine();
                            Console.Write("Type a number (ENTER för exit): ");
                            string str = Console.ReadLine();
                            int number;

                            if (str != "") // Fixar uthopp med Enter (tom sträng).
                            {
                                try
                                {
                                    number = int.Parse(str);
                                }
                                catch
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Not a valid integer!");
                                    Console.ReadLine();
                                    break;
                                }
                                Console.WriteLine(Recursive.RecursiveOdd(number));
                            }
                            else
                            {
                                Console.Clear();
                                break;
                            }
                        } while (true);
                        break;
                    case '2':
                        do
                        {
                            Console.WriteLine();
                            Console.Write("Type n (ENTER för exit) watch out for n > 40: ");
                            string str = Console.ReadLine();
                            int number;

                            if (str != "") // Fixar uthopp med Enter (tom sträng).
                            {
                                try
                                {
                                    number = int.Parse(str);
                                }
                                catch
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Not a valid integer!");
                                    Console.ReadLine();
                                    break;
                                }

                                Console.WriteLine();
                                Console.WriteLine("Print out n = " + number + ":");
                                Console.WriteLine();
                                for (int i = 0; i < number; i++)
                                {
                                    Console.WriteLine("n=" + i + " → " + Fibonacci_R.Fibonaccisekvens(i));
                                }
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.Clear();
                                break;
                            }
                        } while (true);
                        break;
                    case '0':
                        display = false;
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (1, 2 or 0)");
                        Console.ReadLine();
                        break;
                }
            }
        }

        /// <summary>
        /// Examines  IterativeEven(int n)
        /// </summary>
        static void IterativeSub()
        {
            bool display = true;

            while (display)
            {
                Console.Clear();
                Console.WriteLine("EXAMINE ITERATIVE ODD EVENT\n(1 or 0) of your choice\n"
                    + "\n1. Start test of iterative n:th"
                    + "\n2. Start test of fibonacci sequence"
                    + "\n0. Exit Examine odd event");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        do
                        {
                            Console.WriteLine();
                            Console.Write("Type a number (ENTER för exit): ");
                            string str = Console.ReadLine();
                            int number;

                            if (str != "") // Fixar uthopp med Enter (tom sträng).
                            {
                                try
                                {
                                    number = int.Parse(str);
                                }
                                catch
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Not a valid integer!");
                                    Console.ReadLine();
                                    break;
                                }
                                Console.WriteLine(Iterative.IterativeOdd(number));
                            }
                            else
                            {
                                Console.Clear();
                                break;
                            }
                        } while (true);
                        break;
                    case '2':
                        do
                        {
                            Console.WriteLine();
                            Console.Write("Type n (ENTER för exit) max 47: ");
                            string str = Console.ReadLine();
                            int number = 0;


                            if (str != "") // Fixar uthopp med Enter (tom sträng).
                            {
                                try
                                {
                                    number = int.Parse(str);
                                }
                                catch
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Not a valid integer!");
                                    Console.ReadLine();
                                    break;
                                }

                                Console.WriteLine();
                                Console.WriteLine("Print out n = " + number + ":");
                                Console.WriteLine();
                                for (int i = 0; i < number; i++)
                                {
                                    Console.WriteLine("n=" + i + " → " + Fibonacci_I.Fibonaccisekvens(i));
                                }
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.Clear();
                                break;
                            }
                        } while (true);
                        break;
                    case '0':
                        display = false;
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (1, 2 or 0)");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
// 1. Ritade en skiss (ligger som en pdf i Lexicon).
// 2. Value-typen fyller en minnesplats med data medan referens-typen endast pekar på en minnesplats.
// 3. När y sätts lika med x så pekar dessa på samma minnesplats. När sedan y.MyValue laddas med
// talet 4 så blir även innehållet i x.MyValue 4. De har ju samma minnesplats.
// ExamineList:
// 2. När innehållet blir lika stor som arrayen är för tillfället, då ökar den igen.
// 3. Börjar med 4 och ökar sedan med det dubbla (8, 16, 32, 64...).
// 4. Möjligen för att spara dataresurser... Exvis att ständigt behöva justera storleken vid snabba förlopp.
// 5. Nej.
// 6. Vid exvis matematiska operationer, då innehåll, placering och storlek måste styras hårt.
// ExamineQueue.
// 1. Det är alltid den som ställer sig längst bak i kön som blir expiderad först.
// CheckParenthesis:
// 1. List<T>
// Rekursion:
// 1. Har genomfört.
// Iteration:
// 1. Har genomfört.
// Iteration är snabbare men kan fastna i sin egen loop, det kan inte hända för rekursion.
// Ska erkännas, har inte studerat detta innan men efter lite googlande så löste det sig :)