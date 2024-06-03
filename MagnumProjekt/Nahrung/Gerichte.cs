namespace MagnumProjekt.Nahrung;

public static class Gerichte
{
    public static Gericht KLEINER_SALAT = new ("Kleiner Salat", 40*Zutaten.SALAT,35*Zutaten.WURZELN,40*Zutaten.GURKE,17*Zutaten.ÖL,17*Zutaten.SOJASOSSE);
    public static Gericht KICHERERBSENNUDELN_MIT_EI = new ("Kichererbsennudeln mit Ei",100*Zutaten.KICHERERBSENNUDELN, 280*Zutaten.EI,20*Zutaten.ÖL);
    public static Gericht HANDVOLL_MANDELN = new ("Handvoll Mandeln", 100*Zutaten.MANDELN);
    public static Gericht EINE_BANANE = new ("Eine Banane",120*Zutaten.BANANE);
    public static Gericht QUICHE = new("Quiche", 125*Zutaten.WEIZENMEHL, 70*Zutaten.BUTTER, 600*Zutaten.WURZELN,
        200*Zutaten.SCHMAND,100*Zutaten.MILCH,180*Zutaten.EI);
    public static Gericht RÜHREI = new("Rührei", 60*Zutaten.EI,5*Zutaten.BUTTER);
    public static Gericht BACKOFEN_FISCH = new("Backofen-Fisch", 120*Zutaten.BACKOFEN_FISCH);
    public static Gericht KARTOFFELBREI_EIN_KILO = new("Kartoffelbrei",185*Zutaten.MILCH, 10*Zutaten.BUTTER,800*Zutaten.KARTOFFELN);
    public static Gericht TOAST_MIT_SPECK_UND_SPIEGELEI = new("Toast mit Speck und Spiegelei",33*Zutaten.TOAST,20*Zutaten.BUTTER,30*Zutaten.SPECK,120*Zutaten.EI);
    public static Gericht GEBACKENE_BOHNEN_100G = new("Gebackene Bohnen in Tomatensoße", 100*Zutaten.GEBACKENE_BOHNEN);
    public static Gericht TÜTE_CHIPS = new("Eine TÜte mit 150g Chips",150*Zutaten.KARTOFFELCHIPS);
    public static Gericht TOAST_MIT_LACHS =
        new("Toast mit Lachs", 50*Zutaten.LACHS, 66*Zutaten.TOAST, 5*Zutaten.BUTTER);
    public static Gericht TEE_MIT_MILCH_UND_ZUCKER =
        new("Tee mit Milch und Zucker", 4*Zutaten.ZUCKER, 10*Zutaten.MILCH);
    public static Gericht WHISKY_FLASCHE = new("Flasche Whisky", 700*Zutaten.ALKOHOL_40_PROZENT);
    public static Gericht WHISKY_GLAS = new("Glas Whisky", 40*Zutaten.ALKOHOL_40_PROZENT);
    public static Gericht HAFERFLOCKEN_MIT_MILCH =
        new("Haferflocken mit Milch", 100*Zutaten.HAFERFLOCKEN, 180*Zutaten.MILCH);
    public static Gericht BOHNEN_UND_KICHERERBSENNUDELN = new("Gebackene Bohnen und Kichererbsennudeln", 150*Zutaten.KICHERERBSENNUDELN,
        200*Zutaten.GEBACKENE_BOHNEN);
    public static Gericht GEFÜLLTE_TORTELLINI_SUPPE= new("Suppe mit Tortellini", 300*Zutaten.GEFÜLLTE_TORTELLINI,5*Zutaten.ÖL,10*Zutaten.SOJASOSSE);

    public static Gericht KICHERERBSEN_LAUCH_SUPPE = new("Kichererbsen-Lauch-Suppe",
        450 * Zutaten.KICHERERBSEN, 5 * 150 * Zutaten.LAUCH, Zutaten.KARTOFFELN, 10*Zutaten.ÖL,10 * Zutaten.BUTTER);

    public static Gericht EIN_BUENO = new("Ein Bueno", 22 * Zutaten.KINDER_BUENO);
    public static Gericht EIN_DUPLO = new("Ein Duplo", 19 * Zutaten.DUPLO);
    public static Gericht EIN_MANDELHÖRNCHEN = new("Ein Mandelhörnchen", 150 * Zutaten.MANDELHÖRNCHEN);
    public static Gericht EINE_BRATWURST = new("Eine Bratwurst", 100 * Zutaten.BRATWURST);

    public static Gericht ELINS_FRÜHSTÜCK = new("Elin Frühstück", 100 * Zutaten.HAFERFLOCKEN, 200 * Zutaten.MILCH,
        20 * Zutaten.SONNENBLUMENKERNE, 20 * Zutaten.HIMBEEREN, 100 * Zutaten.APFEL);

    public static Gericht LACHS_MIT_MÖHREN_TAGLIATELLE = new("Lachs mit Möhrentagliatelle",150*Zutaten.LACHS,150*Zutaten.WURZELN,150*Zutaten.GRÜNER_SPARGEL,21*Zutaten.ÖL);
    public static Gericht BROT_SELBSTGEBACKEN = new("Selbstgebackenes Brot",750*Zutaten.DINKELVOLLKORNMEHL,180*Zutaten.SONNENBLUMENKERNE,50*Zutaten.LEINSAMEN);
    public static Gericht SCHEIBE_BROT_SELBSTGEBACKEN = 0.05 * BROT_SELBSTGEBACKEN;
    public static Gericht BROT_MIT_KÖRNIGEM_FRISCHKÄSE = (SCHEIBE_BROT_SELBSTGEBACKEN + 5 * Zutaten.BUTTER + 50*Zutaten.KÖRNIGER_FRISCHKÄSE).Namens("Brot mit körnigem Frischkäse");
    
    
    private static void AlleGerichteSortiertNach(Func<Gericht,double> sortierFunktion, bool aufsteigend)
    {
        List<Gericht> alleGerichte = typeof(Gerichte).GetFields().Select(x => (Gericht)x.GetValue(null)).OrderByDescending(sortierFunktion).ToList();
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