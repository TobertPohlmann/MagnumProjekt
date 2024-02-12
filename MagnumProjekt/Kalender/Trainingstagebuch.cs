using MagnumProjekt.Training;

namespace MagnumProjekt.Kalender;

public class TrainingsKalender
{
    public static void SchreibeTrainingsTagebuchIn(Kalender kalender)
    {
        kalender.AddTraining(7,2,2024,new Sitzung(60,
            new ÜbungsEinheit(Übung.ÜberkopfStemmen,(8,10),(8,10),(6,10)),
            new ÜbungsEinheit(Übung.AssistierterKlimmzug,8,8,8,6),
            new ÜbungsEinheit(Übung.KomischesDingMitDerStange,(10,15),(10,15),(6,10)),
            new ÜbungsEinheit(Übung.Ausfallschritt,(10,8),(10,8),(10,8),(10,8))
            ));
        kalender.AddTraining(9,2,2024,new Sitzung(60,
            new ÜbungsEinheit(Übung.FTClubMobilität,1)
            ));
    }
}