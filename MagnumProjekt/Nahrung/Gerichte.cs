namespace MagnumProjekt.Nahrung;

public static class Gerichte
{
    public static Gericht KLEINER_SALAT = new ("Kleiner Salat", (Zutaten.SALAT, 40),(Zutaten.WURZELN,35),(Zutaten.GURKE,40),(Zutaten.ÖL,17),(Zutaten.SOJASOSSE,17));
    public static Gericht HAFERFLOCKEN_MIT_MILCH = new ("Haferflocken mit Milch",(Zutaten.HAFERFLOCKEN, 200), (Zutaten.MILCH, 200));
    public static Gericht NUDELN_MIT_EI = new ("Vollkornnudeln mit Ei",(Zutaten.VOLLKORNNUDELN, 100), (Zutaten.EI, 300),(Zutaten.BUTTER,30));
    public static Gericht LACHS_MIT_REIS = new ("Lachs mit Reis",(Zutaten.LACHS, 200), (Zutaten.REIS, 200), (Zutaten.ÖL, 20));
    public static Gericht NUDELN_MIT_RIND = new ("Rindfleisch mit Nudeln",(Zutaten.RINDFLEISCH, 150), (Zutaten.VOLLKORNNUDELN, 300));
    public static Gericht KICHERERBSENNUDELN_MIT_EI = new ("Kichererbsennudeln mit Ei",(Zutaten.KICHERERBSENNUDELN, 100), (Zutaten.EI, 280),(Zutaten.ÖL,30));
    public static Gericht HANDVOLL_MANDELN = new ("Handvoll Mandeln", (Zutaten.MANDELN, 100));
    public static Gericht EINE_BANANE = new ("Eine Banane",(Zutaten.BANANE, 120));
    public static Gericht QUICHE = new("Quiche", (Zutaten.WEIZENMEHL, 125), (Zutaten.BUTTER, 70), (Zutaten.WURZELN, 600),
        (Zutaten.SCHMAND, 200),(Zutaten.MILCH,100),(Zutaten.EI,180));
    public static Gericht RÜHREI = new("Rührei", (Zutaten.EI, 60),(Zutaten.BUTTER,5));
    public static Gericht BACKOFEN_FISCH = new("Backofen-Fisch", (Zutaten.BACKOFEN_FISCH,120));
    public static Gericht KARTOFFELBREI_EIN_KILO = new("Kartoffelbrei",(Zutaten.MILCH, 185), (Zutaten.BUTTER,10),(Zutaten.KARTOFFELN,800));
    public static Gericht TOAST_MIT_SPECK_UND_SPIEGELEI = new("Toast mit Speck und Spiegelei",(Zutaten.TOAST,100),(Zutaten.BUTTER,20),(Zutaten.SPECK,30),(Zutaten.EI,120));
    public static Gericht GEBACKENE_BOHNEN_100G = new("Gebackene Bohnen in Tomatensoße", (Zutaten.GEBACKENE_BOHNEN, 100));
    public static Gericht TÜTE_CHIPS = new("Eine TÜte mit 150g Chips",(Zutaten.KARTOFFELCHIPS,150));
    
    private static void AlleGerichteSortiertNach(Func<Gericht,double> sortierFunktion, bool aufsteigend)
    {
        List<Gericht> alleGerichte = typeof(Gerichte).GetFields().Select(x => x.GetValue(null) as Gericht).OrderByDescending(sortierFunktion).ToList();
        if (aufsteigend)
        {
            alleGerichte.Reverse();
        }
        
        foreach (var gericht in alleGerichte)
        {
            Console.WriteLine("\n"+ gericht.Name + " --------------");
            gericht.PrintNährwerte(1);
        }
    }

    public static void AlleGerichte(Nährwert sortiertNach = Nährwert.Brennwert, bool aufsteigend = false )
    {
        Func<Gericht, double> sortierFunktion = sortiertNach switch
        {
            Nährwert.Eiweiß => (x => x.GetEiweißAnteil()),
            Nährwert.Kohlenhydrat => (x => x.GetKohlenhydratAnteil()),
            Nährwert.Fett => (x => x.GetFettAnteil()),
            _ => x => x.Brennwert
        };
        AlleGerichteSortiertNach(sortierFunktion,aufsteigend);
    }
}