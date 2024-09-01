namespace Magnum.Model.Nahrung.Data
{
    public class NahrungsDataConverter
    {
        public static List<Gericht> ErzeugeGerichteAusDaten(IEnumerable<GerichtData> alleGerichtDaten, IEnumerable<ZutatData> alleZutatDaten, IEnumerable<BeigabeData> beigabenListe) 
        {
            return alleGerichtDaten.Select(x => ErzeugeGerichtAusDaten(x,alleZutatDaten,beigabenListe)).ToList();
        }

        private static Gericht ErzeugeGerichtAusDaten(GerichtData gerichtData, IEnumerable<ZutatData> alleZutatDaten, IEnumerable<BeigabeData> beigabenListe)
        {
            var gericht = new Gericht(gerichtData.Name);
            Zutat zutat;
            foreach (var beigabe in beigabenListe.Where(b => b.GerichtId == gerichtData.GerichtId))
            {
                gericht.AddZutat(ErzeugeZutatAusDaten(alleZutatDaten.Single(z => z.ZutatId == beigabe.ZutatenId)));
            }
            return gericht;
        }

        public static List<Zutat> ErzeugeZutatenAusDaten(IEnumerable<ZutatData> zutatData)
        {
            return zutatData.Select(x => ErzeugeZutatAusDaten(x)).ToList();
        }

        public static Zutat ErzeugeZutatAusDaten(ZutatData zutatData)
        {
            return new Zutat(zutatData.ZutatName, zutatData.Brennwert, zutatData.Eiweiß, zutatData.Kohlenhydrat, zutatData.Fett);
        }
    }
}
