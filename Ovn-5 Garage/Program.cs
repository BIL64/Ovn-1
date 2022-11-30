using Ovn_5_Garage;

internal class Program
{
    private static void Main(string[] args)
    {
        Manager Man = new();
        Man.Run();
    }
}
// Av Björn Lindqvist 221129.
// Jag försökte att implementera interfacen som ligger i UserInterface men det gick inte...
// Testade LINQ vid allmänn sökning "search everything" men fick det inte att fungera, likaså med IEnumerable...
// IEnumerable visade mycket märkliga sökresultat när jag pekade på garaget. Använde en lista istället...
// Ingen filhantering.
// Inget test har gjorts. För lite tid över (kanske det går åt pipsvängen, men kan göra det senare).
// Gå till "Options" alt 4 för att populera. Med flygplansalternativet (1 plats) kan man testa olika felmedelanden enklare.
// 
// Update 221130 kvällstid: Rättstavning, tog bort alla interface eftersom de inte är implementerade samt ändrat listningen
// med totalantalet (typ 2 of 32). Man kan nu även ta bort fordon när man söker med registreringsnummer.