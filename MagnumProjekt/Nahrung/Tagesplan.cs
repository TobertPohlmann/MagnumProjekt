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
    
    public void PrintTagesNährwert()
    {
        foreach (var gericht in _plan)
        {   
            Console.WriteLine("\n"+gericht.Value +"x  " + gericht.Key.Name + "--------------");
            gericht.Key.PrintNährwerte(gericht.Value);
        }
        Console.WriteLine("\n -----------------GESAMTER TAG ----------------");
        NährwertSchreiber.PrintNährwerte(
            _plan.Sum(x => x.Key.Brennwert*x.Value),
            _plan.Sum(x => x.Key.Eiweiß*x.Value),
            _plan.Sum(x => x.Key.Kohlenhydrat*x.Value),
            _plan.Sum(x => x.Key.Fett*x.Value));
        
    }
}