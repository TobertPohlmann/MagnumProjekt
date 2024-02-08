namespace MagnumProjekt.Nahrung;

public class NährwertSchreiber
{
    public static void PrintNährwert(string nährwert, double value, string einheit, double? referenz = null)
    {
        double printValue = Math.Round(value, 1);
        string message = (nährwert + ":").WithTabs() + (printValue + einheit).WithTabs();
        if (referenz != null)
        {
            message += Math.Round(100*value/referenz.Value, 2) + "%";
        }
        Console.WriteLine(message);
    }
    
    public static void PrintNährwerte(double brennwert,double eiweiß, double kohlenhydrat,double fett)
    {
        var alleNährwerte = eiweiß + kohlenhydrat + fett;
        
        PrintNährwert("Brennwert",brennwert,"kcal");
        PrintNährwert("Eiweiß",eiweiß,"g",alleNährwerte);
        PrintNährwert("Kohlenhydrate",kohlenhydrat,"g",alleNährwerte);
        PrintNährwert("Fett",fett,"g",alleNährwerte);
    }
}