namespace MagnumProjekt;

public class Zutat : INahrungsmittel
{
    public int Brennwert { get; set; }
    public double Eiweiß { get; set; }
    public double Kohlenhydrat { get; set; }
    public double Fett { get; set; }

    public Zutat(int brennwert, double eiweiß, double kohlenhydrat, double fett)
    {
        Brennwert = brennwert;
        Eiweiß = eiweiß;
        Kohlenhydrat = kohlenhydrat;
        Fett = fett;
    }
}