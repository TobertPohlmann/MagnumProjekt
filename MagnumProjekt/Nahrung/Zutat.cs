namespace MagnumProjekt;

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
}