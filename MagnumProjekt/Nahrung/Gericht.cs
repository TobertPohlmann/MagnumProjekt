namespace MagnumProjekt.Nahrung;

public class Gericht : INahrungsmittel
{
    public double Brennwert { get; private set; }
    public double Eiweiß { get; private set; }
    public double Kohlenhydrat { get; private set; }
    public double Fett { get; private set; }

    public string Name { get; private set; } = "";

    private Dictionary<Zutat,int> _zutaten = new();

    public Gericht(string name, params (Zutat,int)[] zutaten)
    {
        Name = name;
        foreach (var zutat in zutaten)
        {
            AddZutat(zutat.Item2,zutat.Item1);
        }
    }

    public void AddZutat(int menge, Zutat zutat)
    {
        _zutaten[zutat] = menge;
        BerechneNährwert();
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
        foreach (KeyValuePair<Zutat,int> zutat in _zutaten)
        {
            Brennwert += zutat.Value / 100.0 * zutat.Key.Brennwert;
            Eiweiß += zutat.Value / 100.0 * zutat.Key.Eiweiß;
            Kohlenhydrat += zutat.Value / 100.0 * zutat.Key.Kohlenhydrat;
            Fett += zutat.Value / 100.0 * zutat.Key.Fett;
        }
    }
    
    
    public void PrintNährwerte(double faktor)
    {
        NährwertSchreiber.PrintNährwerte(faktor*Brennwert,faktor*Eiweiß,faktor*Kohlenhydrat,faktor*Fett);
    }
}