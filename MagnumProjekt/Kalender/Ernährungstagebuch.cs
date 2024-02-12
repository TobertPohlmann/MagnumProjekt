using MagnumProjekt.Nahrung;

namespace MagnumProjekt.Kalender;

public class Ernährungstagebuch
{
    public static void SchreibeErnährungsTagebuchIn(Kalender kalender)
    {
        kalender.AddNahrung(8,2,2024,
            (Gerichte.KICHERERBSENNUDELN_MIT_EI,1),(Gerichte.KLEINER_SALAT,2),(Gerichte.QUICHE,0.25));
        kalender.AddNahrung(9, 2, 2024, 
            (Gerichte.QUICHE, 0.25), (Gerichte.RÜHREI, 3), (Gerichte.KLEINER_SALAT, 0.75),
            (Gerichte.EINE_BANANE, 2), (Gerichte.KARTOFFELBREI_EIN_KILO, 0.25), (Gerichte.BACKOFEN_FISCH, 1), (Gerichte.TÜTE_CHIPS,0.5),(Gerichte.WHISKY_FLASCHE,0.4));
        kalender.AddNahrung(10,2,2024,
            (Gerichte.TOAST_MIT_SPECK_UND_SPIEGELEI,1),(Gerichte.GEBACKENE_BOHNEN_100G,0.5),(Gerichte.KARTOFFELBREI_EIN_KILO,0.125));
        kalender.AddNahrung(12,2,2024,
            (Gerichte.KLEINER_SALAT,1),(Gerichte.KICHERERBSENNUDELN_MIT_EI,0.8),(Gerichte.RÜHREI,3),(Gerichte.HAFERFLOCKEN_MIT_MILCH,1),(Gerichte.EINE_BANANE,1));
    }
}