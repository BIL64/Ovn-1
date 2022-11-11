namespace Ovn_3._2_Polymorfism
{
    internal class Program // Av Björn Lindqvist 221110.
    {
        static void Main(string[] args)
        {
            NumericInputError nie = new NumericInputError();
            TextInputError tie = new TextInputError();
            //MyOwn_1 mo1 = new MyOwn_1(); // funkar ej.
            MyOwn_2 mo2 = new MyOwn_2(); // funkar ej.
            MyOwn_3 mo3 = new MyOwn_3(); // funkar ej.

            List<string> usererrors = new List<string>();
            usererrors.Clear();

            usererrors.Add(nie.UEMessage("Numeric error one"));
            usererrors.Add(nie.UEMessage("Numeric error two"));
            usererrors.Add(nie.UEMessage("Numeric error three"));
            usererrors.Add(tie.UEMessage("Text error one"));
            usererrors.Add(tie.UEMessage("Text error two"));
            usererrors.Add(tie.UEMessage("Text error three"));
            //usererrors.Add(mo2.UEMessage("My own error two")); // Skyddad klass.
            //usererrors.Add(mo3.UEMessage("My own error three")); // Skyddad klass.

            foreach (var item in usererrors)
            {
                Console.WriteLine(item);
            }
            
            Console.ReadLine();
        }
    }
}