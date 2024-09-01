using Magnum.Model.Nahrung.Data;
using Magnum.Model.Nahrung;

namespace Magnum.Api.Models.Data
{
    public class NahrungsDataConverter
    {
        public static Gericht ErzeugeGerichtAusDaten(GerichtData gerichtData, IEnumerable<ZutatData> alleZutatDaten, IEnumerable<BeigabeData> beigabenListe)
        {
            var gericht = new Gericht(gerichtData.Name);
            Zutat zutat;
            foreach (var beigabe in beigabenListe.Where(b => b.GerichtId == gerichtData.GerichtId))
            {
                gericht.AddZutat(ErzeugeZutatAusDaten(alleZutatDaten.Single(z => z.ZutatId == beigabe.ZutatenId)));
            }
            return gericht;
        }

        public static Zutat ErzeugeZutatAusDaten(ZutatData zutatData)
        {
            return new Zutat(zutatData.ZutatName, zutatData.Brennwert, zutatData.Eiweiß, zutatData.Kohlenhydrat, zutatData.Fett);
        }
    }
}
