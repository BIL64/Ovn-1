using Ovn_3._3_Arv;

namespace Ovn_3._4_Mer_polymorfism // Av Björn Lindqvist 221111.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> animlist = new List<string>(); // List<string>.
            animlist.Clear(); // Nollställer listan.
            Console.WriteLine("5. Skriver ut djur. Hälsningar från Wolfman.");
            Console.WriteLine("");

            Wolfman man1 = new Wolfman("Nilly", "1", "3", "bird");
            animlist.Add(man1.MyArray[0]);
            animlist.Add(man1.MyArray[1]);
            animlist.Add(man1.MyArray[2]);
            animlist.Add(man1.MyArray[3]);
            animlist.Add(man1.MyArray[4]);
            animlist.Add(man1.MyArray[5]);
            animlist.Add(man1.MyArray[6]);

            Wolfman man2 = new Wolfman("Ralph", "46", "5", "wolf");
            animlist.Add(man2.MyArray[0]);
            animlist.Add(man2.MyArray[1]);
            animlist.Add(man2.MyArray[2]);
            animlist.Add(man2.MyArray[3]);
            animlist.Add(man2.MyArray[4]);
            animlist.Add(man2.MyArray[5]);
            animlist.Add(man2.MyArray[6]);

            Wolfman man3 = new Wolfman("Fishy", "6", "2", "pelican");
            animlist.Add(man3.MyArray[0]);
            animlist.Add(man3.MyArray[1]);
            animlist.Add(man3.MyArray[2]);
            animlist.Add(man3.MyArray[3]);
            animlist.Add(man3.MyArray[4]);
            animlist.Add(man3.MyArray[5]);
            animlist.Add(man3.MyArray[6]);

            foreach (var item in animlist)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

            List<string> doglist = new List<string>(); // List<string>.
            doglist.Clear(); // Nollställer listan.
            Console.Clear();
            Console.WriteLine("8. Skriver ut tre hundar plus en häst. Hälsningar från Wolfman.");
            Console.WriteLine("");

            Wolfman dog1 = new Wolfman("Buster", "3", "8", "dog");
            doglist.Add(dog1.MyArray[0]);
            doglist.Add(dog1.MyArray[1]);
            doglist.Add(dog1.MyArray[2]);
            doglist.Add(dog1.MyArray[3]);
            doglist.Add(dog1.MyArray[4]);
            doglist.Add(dog1.MyArray[5]);
            doglist.Add(dog1.MyArray[6]);

            Wolfman dog2 = new Wolfman("Wolfy", "7", "12", "dog");
            doglist.Add(dog2.MyArray[0]);
            doglist.Add(dog2.MyArray[1]);
            doglist.Add(dog2.MyArray[2]);
            doglist.Add(dog2.MyArray[3]);
            doglist.Add(dog2.MyArray[4]);
            doglist.Add(dog2.MyArray[5]);
            doglist.Add(dog2.MyArray[6]);

            Wolfman dog3 = new Wolfman("Willy", "4", "10", "dog");
            doglist.Add(dog3.MyArray[0]);
            doglist.Add(dog3.MyArray[1]);
            doglist.Add(dog3.MyArray[2]);
            doglist.Add(dog3.MyArray[3]);
            doglist.Add(dog3.MyArray[4]);
            doglist.Add(dog3.MyArray[5]);
            doglist.Add(dog3.MyArray[6]);

            Wolfman dog4 = new Wolfman("Ego Boy", "687", "9", "horse");
            doglist.Add(dog4.MyArray[0]);
            doglist.Add(dog4.MyArray[1]);
            doglist.Add(dog4.MyArray[2]);
            doglist.Add(dog4.MyArray[3]);
            doglist.Add(dog4.MyArray[4]);
            doglist.Add(dog4.MyArray[5]);
            doglist.Add(dog4.MyArray[6]);

            foreach (var item in doglist)
            {
                Console.WriteLine(item);
            }

            Dog test = new Dog();
            Console.Write(test.WildstringDog()); // Här går det att anropa WildstringDog!

            Console.ReadLine();
        }
    }
}
// Jag hade redan en egenskapsmetod som jag kallade för "Property", därefter ändrade jag namnet till Stats.
// Börjar vid 3, skapa en lista...
// 9. F: Jag måsta ha overridat uppgiften eftersom det går. Det kanske beror på att jag använder en Array?
// 10. F: String.
// 13. F: Jag har ju alltid skrivit ut allt innehåll i Stats...
// 17. F: Bra fråga... Det fungera inte i virtuella metoder. Jag lyckades i Person via en vanlig metod i Animal.
// Det svåraste (för mig) är nog att förstå hur författaren har tänkt sig hur sakerna ska utföras.
// Därmed inte sagt att C# är svårt. Det är mycket svårt, också.