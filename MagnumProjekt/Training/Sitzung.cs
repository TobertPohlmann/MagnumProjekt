namespace MagnumProjekt.Training;

public class Sitzung
{
    public int? Dauer { get; } = null;
    public List<ÜbungsEinheit> ÜbungsEinheiten { get; } = new();

    public Sitzung(int dauer, params ÜbungsEinheit[] übungen)
    {
        Dauer = dauer;
        foreach (var übung in übungen)
        {
            ÜbungsEinheiten.Add(übung);
        }
    }

    public Sitzung(int dauer)
    {
        Dauer = dauer;
    }
    
    public Sitzung() {}
    
}