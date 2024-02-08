namespace MagnumProjekt.Training;

public class ÜbungsEinheit
{
    public Übung Art { get; }
    public List<Satz> Sätze { get; } = new();

    public ÜbungsEinheit(Übung übung, params (int,int)[] sätze)
    {
        Art = übung;
        foreach (var satz in sätze)
        {
            Sätze.Add(new Satz {Wiederholungen = satz.Item1, Gewicht = satz.Item2});
        }
    }
    
    public ÜbungsEinheit(Übung übung, params int[] sätze)
    {
        Art = übung;
        foreach (var satz in sätze)
        {
            Sätze.Add(new Satz {Wiederholungen = satz, Gewicht = null});
        }
    }
}