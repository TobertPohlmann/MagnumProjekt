using MagnumProjekt.Nahrung;

namespace MagnumProjekt.Kalender;

public class Ernährungstagebuch
{
    public static void SchreibeErnährungsTagebuchIn(Kalender kalender)
    {
        kalender.AddNahrung(8,2,2024,new Tagesplan(
            (Gerichte.KICHERERBSENNUDELN_MIT_EI,1),(Gerichte.KLEINER_SALAT,2),(Gerichte.QUICHE,0.25)));
    }
}