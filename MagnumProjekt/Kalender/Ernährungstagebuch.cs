using MagnumProjekt.Nahrung;

namespace MagnumProjekt.Kalender;

public class Ernährungstagebuch
{
    public static void SchreibeErnährungsTagebuchIn(Kalender kalender)
    {
        kalender.AddNahrung(8,2,2024,
            Gerichte.KICHERERBSENNUDELN_MIT_EI,
            2*Gerichte.KLEINER_SALAT,
            0.25*Gerichte.QUICHE);
        
        kalender.AddNahrung(9, 2, 2024, 
            0.25*Gerichte.QUICHE, 
            3*Gerichte.RÜHREI, 
            0.75*Gerichte.KLEINER_SALAT,
            2*Gerichte.EINE_BANANE, 
            (0.25*Gerichte.KARTOFFELBREI_EIN_KILO+Gerichte.BACKOFEN_FISCH).Namens("Kartoffelbrei mit Backofenfisch"),
            0.5*Gerichte.TÜTE_CHIPS,
            0.4*Gerichte.WHISKY_FLASCHE);
        
        kalender.AddNahrung(10,2,2024,
            Gerichte.TOAST_MIT_SPECK_UND_SPIEGELEI,
            (0.5*Gerichte.GEBACKENE_BOHNEN_100G+0.125*Gerichte.KARTOFFELBREI_EIN_KILO).Namens("Kartoffelbrei und Bohnen")
            );
        
        kalender.AddNahrung(12,2,2024,
            Gerichte.KLEINER_SALAT,
            0.8*Gerichte.KICHERERBSENNUDELN_MIT_EI,
            3*Gerichte.RÜHREI,
            Gerichte.HAFERFLOCKEN_MIT_MILCH,
            Gerichte.EINE_BANANE);
        
        kalender.AddNahrung(13,2,2024,
            Gerichte.KLEINER_SALAT,
            Gerichte.GEFÜLLTE_TORTELLINI_SUPPE,
            (3*Gerichte.RÜHREI + 150*Zutaten.VOLLKORNNUDELN + 180*Zutaten.GEBACKENE_BOHNEN).Namens("Nudeln mit Ei und Bohnen"),
            Gerichte.EINE_BANANE);
        
        kalender.AddNahrung(14,2,2024,
            Gerichte.KLEINER_SALAT,
            Gerichte.GEFÜLLTE_TORTELLINI_SUPPE,
            0.3*Gerichte.KICHERERBSEN_LAUCH_SUPPE,
            0.3*Gerichte.TÜTE_CHIPS);
            
        kalender.AddNahrung(15,2,2024,
            Gerichte.KLEINER_SALAT,
            0.3*Gerichte.KICHERERBSEN_LAUCH_SUPPE,
            Gerichte.EIN_BUENO,
            Gerichte.EIN_DUPLO);

        kalender.AddNahrung(16, 2, 2024,
            Gerichte.KLEINER_SALAT,
            Gerichte.GEFÜLLTE_TORTELLINI_SUPPE,
            3 * Gerichte.RÜHREI);
        
        kalender.AddNahrung(19,2,2024,
            Gerichte.KLEINER_SALAT,
            (200*Zutaten.SCHWEINEFILET + 200*Zutaten.VOLLKORNNUDELN + 30*Zutaten.ÖL + 50*Zutaten.SAHNE).Namens("Schweinefilet mit Vollkornnudeln und Soße")
            );
        
        kalender.AddNahrung(20,2,2024,
            200*Zutaten.VOLLKORNNUDELN+200*Zutaten.BRATWURST + 30*Zutaten.GEWÜRZ_KETCHUP,
            Gerichte.EINE_BANANE,
            4*Gerichte.RÜHREI,
            200*Zutaten.HAFERFLOCKEN + 350*Zutaten.MILCH + 30*Zutaten.MANDELN
        );

        kalender.AddNahrung(29,4,2024,
            100*Zutaten.HAFERFLOCKEN+150*Zutaten.MILCH+20*Zutaten.PINIENKERNE,
            80*Zutaten.KICHERERBSENNUDELN + 3*Gerichte.RÜHREI,
            2*Gerichte.KLEINER_SALAT,
            300*Zutaten.BRATWURST + 90*Zutaten.KRÄUTERBUTTERBROT + 25*Zutaten.GEWÜRZ_KETCHUP
        );

        kalender.AddNahrung(30,4,2024,
            100*Zutaten.KICHERERBSENNUDELN + 3*Gerichte.RÜHREI,
            Gerichte.KLEINER_SALAT
            );
    }
    public static void SchreibeElinsErnährungsTagebuchIn(Kalender kalender)
    {
        kalender.AddNahrung(3,6,2024,
            Gerichte.ELINS_FRÜHSTÜCK,
            Gerichte.LACHS_MIT_MÖHREN_TAGLIATELLE,
            Zutaten.APFEL.AlsGericht(),
            4*Gerichte.TEE_MIT_MILCH_UND_ZUCKER,
            (300*Zutaten.WASSERMELONE).AlsGericht());
    }
}