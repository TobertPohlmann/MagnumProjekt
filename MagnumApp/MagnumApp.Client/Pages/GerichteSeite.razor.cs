using Magnum.Model.Nahrung;
using Magnum.Shared;
using Microsoft.AspNetCore.Components;

namespace MagnumApp.Client.Pages
{
    public partial class GerichteSeite
    {
        [Inject]
        public ApplicationState? ApplicationState { get; set; }
        public List<Gericht>? Gerichte { get; set; } = default!;

        public int Länge { get; set; } = -1;

        protected override async Task OnInitializedAsync()
        {
            Gerichte = await ApplicationState.GetGerichte();
        }
    }
}
