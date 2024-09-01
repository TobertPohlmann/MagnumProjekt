using Magnum.Model.Nahrung;
using MagnumProjekt.Nahrung;
using MagnumProjekt.Training;

namespace MagnumProjekt.Kalender;

public class Kalender
{
    private Dictionary<DateOnly, Tagesplan> _nahrungsKalender = new();
    private Dictionary<DateOnly, Sitzung> _trainingsKalender = new();
    private Dictionary<DateOnly, double> _gewichtsKalender = new();
    public void AddNahrung(int tag, int monat, int jahr, params Gericht[] gerichte)
    {
        Tagesplan nahrungsplan = new Tagesplan(gerichte);
        DateOnly datum = new DateOnly(jahr, monat, tag);
        _nahrungsKalender[datum] = nahrungsplan;
    }

    public Tagesplan GetErnährung(int tag, int monat, int jahr)
    {
        return GetEintrag(tag,monat,jahr,_nahrungsKalender);
    }

    public void AddTraining(int tag, int monat, int jahr, Sitzung training)
    {
        DateOnly datum = new DateOnly(jahr, monat, tag);
        _trainingsKalender[datum] = training;
    }

    public Sitzung GetTraining(int tag, int monat, int jahr)
    {
        return GetEintrag(tag,monat,jahr,_trainingsKalender);
    }

    public void AddGewicht(int tag, int monat, int jahr, double gewicht)
    {
        DateOnly datum = new DateOnly(jahr, monat, tag);
        _gewichtsKalender[datum] = gewicht;
    }

    public double GetGewicht(int tag, int monat, int jahr)
    {
        return GetEintrag(tag, monat, jahr, _gewichtsKalender);
    }

    private static T GetEintrag<T>(int tag, int monat, int jahr, Dictionary<DateOnly,T> kalender)
    {
        var datum = new DateOnly(jahr, monat, tag);
        if (!kalender.ContainsKey(datum))
        {
            throw new Exception(datum +" hat keinen Eintrag für "+ typeof(T));
        }
        return kalender[datum];
    }
}