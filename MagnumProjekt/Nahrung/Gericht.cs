namespace MagnumProjekt.Nahrung;

public struct Gericht : INahrungsmittel
{
    private double _brennwert;
    private double _eiweiß;
    private double _kohlenhydrat;
    private double _fett;
    public double Brennwert {
        get { return _brennwert * _faktor; }
    }
    public double Eiweiß {
        get { return _eiweiß * _faktor; }
    }
    public double Kohlenhydrat {
        get { return _kohlenhydrat * _faktor; }
    }
    public double Fett {
        get { return _fett * _faktor; }
    }
    public string Name { get; private set; } = "";
    private Dictionary<string,Beigabe> Zutaten { get; } = new();

    private double _faktor = 1.0;
    
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
                dieseZutat = inhalt.Value.Zutat;
                menge = inhalt.Value.Menge;
                neuesGericht.AddZutat(menge,dieseZutat);
            }
        }
        return neuesGericht.Namens(neuerName.Substring(0, neuerName.Length - 3));
    }

    public static Gericht operator +(Gericht a, Gericht b) => Gericht.AusKombinationVon(a,b);

    public static Gericht operator *(double faktor, Gericht a)
    {
        Gericht b = a;
        b._faktor = faktor;
        return b;
    }

    public static Gericht operator +(Gericht a, Zutat zutat)
    {
        Gericht b = a;
        b.AddZutat(zutat/b._faktor);
        return b;
    }
    
    public static Gericht operator +(Zutat zutat, Gericht a)
    {
        return a + zutat;
    }
    
    public Gericht Namens(string name)
    {
        Name = name;
        return this;
    }

    public void AddZutat(int menge, Zutat zutat)
    {
        if (!Zutaten.ContainsKey(zutat.Name))
        {
            Zutaten[zutat.Name] = new Beigabe(zutat,menge);
        }
        else
        {
            int vorigeMenge = Zutaten[zutat.Name].Menge;
            Zutaten[zutat.Name] = new Beigabe(zutat,menge+vorigeMenge);
        }
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
        _brennwert = 0;
        _eiweiß = 0;
        _kohlenhydrat = 0;
        _fett = 0;
        foreach (Beigabe beigabe in Zutaten.Values)
        {
            _brennwert += beigabe.Menge / 100.0 * beigabe.Zutat.Brennwert;
            _eiweiß += beigabe.Menge / 100.0 * beigabe.Zutat.Eiweiß;
            _kohlenhydrat += beigabe.Menge / 100.0 * beigabe.Zutat.Kohlenhydrat;
            _fett += beigabe.Menge / 100.0 * beigabe.Zutat.Fett;
        }
    }
    
    public void PrintNährwerte(double faktor)
    {
        Console.WriteLine("\n"+faktor+"x "+Name+" -----------");
        NährwertSchreiber.PrintNährwerte(faktor*Brennwert,faktor*Eiweiß,faktor*Kohlenhydrat,faktor*Fett);
    }
}

public record Beigabe(Zutat Zutat, int Menge);