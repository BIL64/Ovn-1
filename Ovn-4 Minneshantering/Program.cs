using System.Diagnostics;
using static System.Reflection.Metadata.BlobBuilder;

namespace Ovn_4_Minneshantering // Av Björn Lindqvist 221117. Uppdaterad 221121.
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
                    + "\n7. Odd Generator by BL"
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
                    case '7':
                        OddGenerator();
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
                // Jag använde listor först men bytte sedan till köer. Köer fungerar lika bra samt slukar mindre datorkraft.
                Queue<char> _queue = new Queue<char>(); // Kö för koll av intrasslade parenteser.
                Queue<char> even_queue = new Queue<char>(); // Kö för jämna index.
                Queue<char> odd_queue = new Queue<char>(); // Kö för udda index.

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
                            bool entangled = false; // Flagga för intrasslade parenteser.

                            int rtal = 0; // Tal för symetritester.
                            int stal = 0;
                            int ctal = 0;
                            _queue.Clear();
                            even_queue.Clear();
                            odd_queue.Clear();
                            Console.WriteLine();
                            Console.Write("Add string (ENTER för exit): ");
                            string str = Console.ReadLine();

                            if (str != "") // Fixar uthopp med Enter (tom sträng).
                            {
                                Char[] chars = str.ToCharArray(); // Gör först en array av strängen.

                                for (int i = 0; i < str.Length; i++) // Ny version: Nedkortad utvärdering av spegelsymetri.
                                {
                                    if (chars[i] == '(' || chars[i] == ')') // Round brackets.
                                    {
                                        if (chars[i] == '(') rtal++; else rtal--; // Ökar eller minskar round-tal.
                                        if (chars[i] == '(') _queue.Enqueue('('); else _queue.Enqueue(')'); // Kö för trasselparenteserna.
                                    }

                                    if (chars[i] == '[' || chars[i] == ']') // Square brackets.
                                    {
                                        if (chars[i] == '[') stal++; else stal--; // Ökar eller minskar square-tal.
                                        if (chars[i] == '[') _queue.Enqueue('['); else _queue.Enqueue(']'); // Kö för trasselparenteserna.
                                    }

                                    if (chars[i] == '{' || chars[i] == '}') // Curly brackets.
                                    {
                                        if (chars[i] == '{') ctal++; else ctal--; // Ökar eller minskar curly-tal.
                                        if (chars[i] == '{') _queue.Enqueue('{'); else _queue.Enqueue('}'); // Kö för trasselparenteserna.
                                    }
                                }

                                if (rtal != 0) rb_flag = true; // Om talen är positiva eller negativa så tyder det på osymetri.
                                if (stal != 0) sb_flag = true;
                                if (ctal != 0) cb_flag = true; // Slut spegelsymetri.

                                int tal1 = 0; // Här börjar check av intrasslade parenteser.
                                int tal2 = 0; // Larmar även vid osymetri.
                                int rak = 0;

                                foreach (var item in _queue) // Ny version: Laddar köerna med jämna- respektive ojämna parenteser.
                                {                            // Det är det som är hemligheten. Jag kom på det själv.
                                    if (rak % 2 == 0) even_queue.Enqueue(item); else odd_queue.Enqueue(item);
                                    rak++;
                                }

                                foreach (var item in even_queue) // Innehållet i jämn-kön omvandlas till tal beroende på tecken.
                                {
                                    if (item == '(' || item == ')') tal1 += 1;
                                    if (item == '[' || item == ']') tal1 += 2;
                                    if (item == '{' || item == '}') tal1 += 3;
                                }

                                foreach (var item in odd_queue) // Innehållet i udd-kön omvandlas till tal beroende på tecken.
                                {
                                    if (item == '(' || item == ')') tal2 += 1;
                                    if (item == '[' || item == ']') tal2 += 2;
                                    if (item == '{' || item == '}') tal2 += 3;
                                }
                                if (tal1 != tal2 && tal1 > 1 && tal2 > 1) entangled = true; // Om talen är olika så kan det tyda på intrassling.

                                if (rb_flag)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Round () brackets are NOT shapely!");
                                }

                                if (sb_flag)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Square [] brackets are NOT shapely!");
                                }

                                if (cb_flag)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Curly {} brackets are NOT shapely!");
                                }

                                if (entangled)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("There are brackets that can be ENTANGLED...");
                                }
                                if (BrackRevOrder.Test(_queue)) // Anropar klass.
                                {
                                    Console.WriteLine();
                                    if (entangled) Console.WriteLine("or some brackets may be REVERSE order");
                                    else Console.WriteLine("Some brackets may be REVERSE order");
                                }

                                if (!rb_flag && !sb_flag && !cb_flag && !entangled && !BrackRevOrder.Test(_queue))
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Everything looks fine.");
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
        /// Examines  RecursiveEven(int n)
        /// </summary>
        static void RecursiveSub()
        {
            bool display = true;

            while (display)
            {
                Console.Clear();
                Console.WriteLine("EXAMINE RECURSIVE ODD EVENT\n(1, 2 or 0) of your choice\n"
                    + "\n1. Start test of recursive n:th"
                    + "\n2. Start test of Fibonacci sequence"
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
                                Console.WriteLine(Recursive.RecursiveOdd(number)); //Klassanrop.
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
                                    Console.WriteLine("n=" + i + " → " + Fibonacci_R.Fibonaccisekvens(i)); //Klassanrop.
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
                Console.WriteLine("EXAMINE ITERATIVE ODD EVENT\n(1, 2 or 0) of your choice\n"
                    + "\n1. Start test of iterative n:th"
                    + "\n2. Start test of Fibonacci sequence"
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
                                Console.WriteLine(Iterative.IterativeOdd(number)); //Klassanrop.
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
                            Console.Write("Type n (ENTER för exit) max 94: ");
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
                                    Console.WriteLine("n=" + i + " → " + Fibonacci_I.Fibonaccisekvens(i)); // Klassanrop.
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
                        Console.WriteLine("Please enter some valid input (1, 2 or 0)");
                        Console.ReadLine();
                        break;
                }
            }
        }
    

        /// <summary>
        /// Examines  OddGenerator by BL
        /// </summary>
        static void OddGenerator()
        {
            bool display = true;

            while (display)
            {
                Console.Clear();
                Console.WriteLine("EXAMINE ODD GENERATOR BY BL\n(1, 2 or 0) of your choice\n"
                    + "\n1. Start test of odd generator n:th"
                    + "\n2. Read document by BL"
                    + "\n0. Exit Examine odd generator");
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
                                Console.WriteLine(Generator.OddGenerator(number)); //Klassanrop.
                            }
                            else
                            {
                                Console.Clear();
                                break;
                            }
                        } while (true);
                        break;
                    case '2':
                        Console.WriteLine();
                        Console.WriteLine("Från pdf-filen Recursion");
                        Console.WriteLine();
                        Console.WriteLine("Har studerat den rekursiva funktionen genom att testa med olika värden.");
                        Console.WriteLine("Jag har lagt in en breakpoint och stegat mig igenom funktionen, men jag");
                        Console.WriteLine("kan (till skillnad mot den iterativa) inte förstå vad det är som händer.");
                        Console.WriteLine();
                        Console.WriteLine("Det börjar med att den anropar sig själv x antal gånger, sedan när n = 1");
                        Console.WriteLine("så går den in i if-satsens retur, därefter går den till sista klammern");
                        Console.WriteLine("och HOPPAR sedan tillbaks till den andra returen, sedan hoppar den fram");
                        Console.WriteLine("och tillbaks x anta gånger. Därefter adderas två innan den lämnar.");
                        Console.WriteLine();
                        Console.WriteLine("Det blir rätt, men hur - det vet jag inte. Ett enklare sätt om man är ute");
                        Console.WriteLine("efter udda nummer av n är att multiplicera med två och sedan subtrahera");
                        Console.WriteLine("med ett (n = n x 2 – 1).");
                        Console.ReadLine();
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
// 1. Queue<string>

// Rekursion:
// 1. Har genomfört.

// Iteration:
// 1. Har genomfört.

// Iteration är snabbare men kan fastna i sin egen loop, det kan inte hända för rekursion.
// Ska erkännas, har inte studerat detta innan men efter lite googlande så löste det sig :)

// 221121: Har uppdaterat en hel del. Listor är bytta mot köer i parenteschecken, symetrichecken är rejält
// nedkortad, ett pdf-dokument om rekursion, OddGenerator är en udda metod för udda tal samt ingen bättre metod
// för intrasslade parenteser har jag lyckats klämma fram. Jag har ändrat "nested" till "entangled" eftersom
// nästlade/kapslade parenteser är helt ok. Lyckades inte lösa mysteriet med bakoframvända parenteser, bara nästan.
// Det går nog att fixa men har varit tvungen att hinna läsa/repetera andra saker också...