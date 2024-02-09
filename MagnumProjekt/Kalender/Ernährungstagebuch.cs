using MagnumProjekt.Nahrung;

namespace MagnumProjekt.Kalender;

public class Ernährungstagebuch
{
    public static void SchreibeErnährungsTagebuchIn(Kalender kalender)
    {
        kalender.AddNahrung(8,2,2024,new Tagesplan(
            (Gerichte.KICHERERBSENNUDELN_MIT_EI,1),(Gerichte.KLEINER_SALAT,2),(Gerichte.QUICHE,0.25)));
        kalender.AddNahrung(9,2,2024,new Tagesplan(
            (Gerichte.QUICHE,0.25),(Gerichte.RÜHREI,3),(Gerichte.KLEINER_SALAT,0.75),(Gerichte.EINE_BANANE,1)));
    }
}