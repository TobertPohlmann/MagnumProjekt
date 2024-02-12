using System.Security.Cryptography;

namespace MagnumProjekt.Nahrung;

public class Gericht : INahrungsmittel
{
    public double Brennwert { get; private set; }
    public double Eiweiß { get; private set; }
    public double Kohlenhydrat { get; private set; }
    public double Fett { get; private set; }
    public string Name { get; private set; } = "";
    private Dictionary<Zutat,int> Zutaten { get; } = new();

    public Gericht(string name, params Zutat[] zutaten)
    {
        Name = name;
        foreach (var zutat in zutaten)
        {
            AddZutat(zutat);
        }
    }

    private static Gericht AusKombinationVon(params Gericht[] gerichte)
    {
        Gericht neuesGericht = new("temp");
        string neuerName = "";
        Zutat dieseZutat;
        int menge;
        foreach (var gericht in gerichte)
        {
            neuerName += gericht.Name + " + ";
            foreach (var inhalt in gericht.Zutaten)
            {
                dieseZutat = inhalt.Key;
                menge = inhalt.Value;
                neuesGericht.AddZutat(menge,dieseZutat);
            }
        }
        return neuesGericht.Namens(neuerName.Substring(0, neuerName.Length - 3));
    }

    public static Gericht operator +(Gericht a, Gericht b) => Gericht.AusKombinationVon(a,b);

    public static Gericht operator *(double faktor, Gericht a)
    {
        Gericht b = new(a.Name);
        foreach (var inhalt in a.Zutaten)
        {
            b.AddZutat(Convert.ToInt32(faktor*inhalt.Value),inhalt.Key);            
        }
        return b;
    }

    public Gericht Namens(string name)
    {
        Name = name;
        return this;
    }

    public void AddZutat(int menge, Zutat zutat)
    {
        if (Zutaten.ContainsKey(zutat))
        {
            Zutaten[zutat] = 0;
        }
        Zutaten[zutat] += menge;
        BerechneNährwert();
    }

    public void AddZutat(Zutat zutat)
    {
        AddZutat(100,zutat);
    }

    public double GetEiweißAnteil()
    {
        return Eiweiß / (Eiweiß + Kohlenhydrat + Fett);
    }
    
    public double GetKohlenhydratAnteil()
    {
        return Kohlenhydrat / (Eiweiß + Kohlenhydrat + Fett);
    }
    
    public double GetFettAnteil()
    {
        return Fett / (Eiweiß + Kohlenhydrat + Fett);
    }

    private void BerechneNährwert()
    {
        Brennwert = 0;
        Eiweiß = 0;
        Kohlenhydrat = 0;
        Fett = 0;
        foreach (KeyValuePair<Zutat,int> zutat in Zutaten)
        {
            Brennwert += zutat.Value / 100.0 * zutat.Key.Brennwert;
            Eiweiß += zutat.Value / 100.0 * zutat.Key.Eiweiß;
            Kohlenhydrat += zutat.Value / 100.0 * zutat.Key.Kohlenhydrat;
            Fett += zutat.Value / 100.0 * zutat.Key.Fett;
        }
    }
    
    
    public void PrintNährwerte(double faktor)
    {
        Console.WriteLine("\n"+faktor+"x "+Name+" -----------");
        NährwertSchreiber.PrintNährwerte(faktor*Brennwert,faktor*Eiweiß,faktor*Kohlenhydrat,faktor*Fett);
    }
}