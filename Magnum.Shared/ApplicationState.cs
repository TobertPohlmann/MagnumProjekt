using Magnum.Model.Nahrung;
using Magnum.Model.Nahrung.Data;
using Magnum.Shared.Services;

namespace Magnum.Shared
{
    public class ApplicationState
    {
        private readonly IGerichtDataService? _gerichtDataService;

        private readonly IZutatDataService? _zutatDataService;

        private readonly IBeigabeDataService? _beigabeDataService;

        public Task LadeTask { get; private set; }

        private List<Gericht>? _gerichte = null;
        private List<Zutat>? _zutaten = null;


        public ApplicationState(IGerichtDataService gerichtDataService, IZutatDataService zutatDataService, IBeigabeDataService beigabeDataService)
        {
            _gerichtDataService = gerichtDataService;
            _beigabeDataService = beigabeDataService;
            _zutatDataService = zutatDataService;
            LadeTask = LadeDaten();
        }

        public async Task<List<Gericht>> GetGerichte() 
        {
            if (_gerichte == null) 
            {
                await LadeTask;            
            }
            return _gerichte;
        }

        public async Task<List<Zutat>> GetZutaten()
        {
            if (_gerichte == null)
            {
                await LadeTask;
            }
            return _zutaten;
        }

        private async Task LadeDaten()
        {
            var gerichtDataTask = _gerichtDataService.GetGerichte();
            var gerichtData = (await gerichtDataTask).ToList();
            gerichtDataTask.Wait();
            var zutatDataTask = _zutatDataService.GetZutaten();
            var zutatData = (await zutatDataTask).ToList();
            zutatDataTask.Wait();
            var beigabeDataTask = _beigabeDataService.GetBeigaben();
            var beigabeData = (await beigabeDataTask).ToList();
            beigabeDataTask.Wait();

            _gerichte = NahrungsDataConverter.ErzeugeGerichteAusDaten(gerichtData, zutatData, beigabeData);
            _zutaten = NahrungsDataConverter.ErzeugeZutatenAusDaten(zutatData);
        }
    }
}
