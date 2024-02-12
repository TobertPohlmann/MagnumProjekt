using MagnumProjekt.Nahrung;

namespace MagnumProjekt.Kalender;

public class Ernährungstagebuch
{
    public static void SchreibeErnährungsTagebuchIn(Kalender kalender)
    {
        kalender.AddNahrung(8,2,2024,
            Gerichte.KICHERERBSENNUDELN_MIT_EI,2*Gerichte.KLEINER_SALAT,0.25*Gerichte.QUICHE);
        kalender.AddNahrung(9, 2, 2024, 
            0.25*Gerichte.QUICHE, 3*Gerichte.RÜHREI, 0.75*Gerichte.KLEINER_SALAT,
            2*Gerichte.EINE_BANANE, 0.25*Gerichte.KARTOFFELBREI_EIN_KILO, Gerichte.BACKOFEN_FISCH, 0.5*Gerichte.TÜTE_CHIPS,0.4*Gerichte.WHISKY_FLASCHE);
        kalender.AddNahrung(10,2,2024,
            Gerichte.TOAST_MIT_SPECK_UND_SPIEGELEI,0.5*Gerichte.GEBACKENE_BOHNEN_100G,0.125*Gerichte.KARTOFFELBREI_EIN_KILO);
        kalender.AddNahrung(12,2,2024,
            Gerichte.KLEINER_SALAT,0.8*Gerichte.KICHERERBSENNUDELN_MIT_EI,3*Gerichte.RÜHREI,Gerichte.HAFERFLOCKEN_MIT_MILCH,Gerichte.EINE_BANANE);
    }
}