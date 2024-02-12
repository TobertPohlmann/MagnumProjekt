namespace MagnumProjekt.Nahrung;

public class Zutat : INahrungsmittel
{
    public double Brennwert { get; }
    public double Eiweiß { get; }
    public double Kohlenhydrat { get; }
    public double Fett { get; }

    public Zutat(double brennwert, double eiweiß, double kohlenhydrat, double fett)
    {
        Brennwert = brennwert;
        Eiweiß = eiweiß;
        Kohlenhydrat = kohlenhydrat;
        Fett = fett;
    }

    public static Zutat operator *(double gramm, Zutat a) => new Zutat(gramm/100.0 * a.Brennwert, gramm/100.0 * a.Eiweiß,
        gramm/100.0 * a.Kohlenhydrat, gramm/100.0 * a.Fett);
}