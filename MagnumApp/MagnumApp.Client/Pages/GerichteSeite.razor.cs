using Magnum.Model.Nahrung;
using MagnumApp.Client.Services;
using Microsoft.AspNetCore.Components;

namespace MagnumApp.Client.Pages
{
    public partial class GerichteSeite
    {
        [Inject]
        public IGerichtDataService? GerichtDataService { get; set; }
        public List<Gericht>? Gerichte { get; set; } = default!;

        protected override async Task OnInitializedAsync()
        {
            //Gerichte = (await GerichtDataService.GetGerichte()).ToList();
            Gerichte = new List<Gericht>();
            Gerichte.Add(new Gericht("Testgericht"));
            Gerichte.Add(new Gericht("Noch ein Testgericht"));
        }
    }
}
