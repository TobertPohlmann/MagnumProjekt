using MagnumProjekt.Training;

namespace MagnumProjekt.Kalender;

public class TrainingsKalender
{
    public static void SchreibeTrainingsTagebuchIn(Kalender kalender)
    {
        kalender.AddTraining(7,2,2024,new Sitzung(60,
            new ÜbungsEinheit(Übung.ÜberkopfStemmen,(8,10),(8,10),(6,10)),
            new ÜbungsEinheit(Übung.AssistierterKlimmzug,8,8,8,6),
            new ÜbungsEinheit(Übung.KomischesDingAufDenKnienMitDerStange,(10,15),(10,15),(6,10)),
            new ÜbungsEinheit(Übung.Ausfallschritt,(10,8),(10,8),(10,8),(10,8))
            ));
        
        kalender.AddTraining(9,2,2024,new Sitzung(60,
            new ÜbungsEinheit(Übung.FTClubMobilität,1)
            ));
        
        kalender.AddTraining(12,2,2024, new Sitzung(60,
            new ÜbungsEinheit(Übung.Schlittenziehen,(15,75),(15,75)),
            new ÜbungsEinheit(Übung.BankKniebeugen,(10,8),(20,8),(20,8),(30,8)),
            new ÜbungsEinheit(Übung.GewichthebenZurBrust,(10,6),(10,6),(10,6),(20,6)),
            new ÜbungsEinheit(Übung.BankKniebeugen,30)
        ));
        
        kalender.AddTraining(13,2,2024,new Sitzung(60,
            new ÜbungsEinheit(Übung.FTClubMobilität,1)
        ));
    }
}