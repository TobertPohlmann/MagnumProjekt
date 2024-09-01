using MagnumProjekt.Nahrung;

namespace Magnum.Model.Nahrung;

public struct Zutat : INahrungsmittel
{
    public string Name { get; }
    public double Brennwert { get; }
    public double Eiweiß { get; }
    public double Kohlenhydrat { get; }
    public double Fett { get; }

    public Zutat(string name, double brennwert, double eiweiß, double kohlenhydrat, double fett)
    {
        Name = name;
        Brennwert = brennwert;
        Eiweiß = eiweiß;
        Kohlenhydrat = kohlenhydrat;
        Fett = fett;
    }

    public Gericht AlsGericht()
    {
        return new Gericht(Name, this);
    }

    public static Zutat operator *(double gramm, Zutat a) => new Zutat(a.Name, gramm / 100.0 * a.Brennwert, gramm / 100.0 * a.Eiweiß,
        gramm / 100.0 * a.Kohlenhydrat, gramm / 100.0 * a.Fett);

    public static Zutat operator /(Zutat a, double faktor) => new Zutat(a.Name, a.Brennwert / faktor, a.Eiweiß / faktor,
        a.Kohlenhydrat / faktor, a.Fett / faktor);

    public static Gericht operator +(Zutat a, Zutat b)
    {
        return new Gericht(a.Name + " + " + b.Name, a, b);
    }
}