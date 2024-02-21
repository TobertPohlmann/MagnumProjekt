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
        
        
        kalender.AddNahrung(21,2,2024,
            Gerichte.KLEINER_SALAT,
//            180*Zutaten.EI+120*Zutaten.KICHERERBSENNUDELN+20*Zutaten.ÖL,
            3*Gerichte.RÜHREI+120*Zutaten.KICHERERBSENNUDELN,
            Gerichte.EIN_MANDELHÖRNCHEN
        );

    }
    
}