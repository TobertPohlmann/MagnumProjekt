using Magnum.Model.Nahrung;
using Magnum.Model.Nahrung.Data;

namespace Magnum.Api.Models
{
    public class NahrungDataExtraktor
    {
        private int _zutatIdCounter = 1;
        private int _gerichtIdCounter = 1;

        private Dictionary<string, ZutatData> _zutatData = new();


        public List<ZutatData> GetZutatData() 
        {
            return _zutatData.Values.ToList();
        }

        public void RegistriereZutatData(Zutat zutat) 
        {
            if (!_zutatData.ContainsKey(zutat.Name)) 
            {
                _zutatData[zutat.Name] = new ZutatData
                {
                    ZutatName = zutat.Name,
                    Brennwert = zutat.Brennwert,
                    Eiweiß = zutat.Eiweiß,
                    Fett = zutat.Fett,
                    Kohlenhydrat = zutat.Kohlenhydrat,
                    ZutatId = _zutatIdCounter
                };
                _zutatIdCounter++;
            }
        }

        public Tuple<GerichtData, List<BeigabeData>> ExtrahiereGerichtData(Gericht gericht) 
        {
            var gerichtData = new GerichtData { Name = gericht.Name, GerichtId = _gerichtIdCounter };
            _gerichtIdCounter++;

            var zutatenListe = new List<BeigabeData>();
            foreach(Beigabe beigabe in gericht.Zutaten.Values) 
            {
                zutatenListe.Add(new BeigabeData
                {
                    GerichtId = gerichtData.GerichtId,
                    ZutatenId = SucheZutatDataId(beigabe.Zutat),
                    Menge = beigabe.Menge
                });
            }
            return Tuple.Create(gerichtData, zutatenListe);            
        }

        private int SucheZutatDataId(Zutat zutat)
        {
            RegistriereZutatData(zutat);

            return _zutatData[zutat.Name].ZutatId;
        }

    }
}
