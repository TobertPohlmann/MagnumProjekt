namespace MagnumProjekt.Nahrung;

public class Tagesplan
{
    public Dictionary<Gericht,double> _plan = new ();

    public Tagesplan()
    {
    }
    
    public Tagesplan(params (Gericht,double)[] gerichte)
    {
        foreach (var gericht in gerichte)
        {
            AddGericht(gericht.Item1,gericht.Item2);
        }        
    }
    
    public Tagesplan(params Gericht[] gerichte)
    {
        foreach (var gericht in gerichte)
        {
            AddGericht(gericht);
        }        
    }

    public void AddGericht(Gericht gericht,double faktor = 1)
    {
        _plan[gericht] = faktor;
    }
}