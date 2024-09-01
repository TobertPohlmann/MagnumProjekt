using Magnum.Shared;
using Microsoft.AspNetCore.Components;

namespace MagnumApp.Client.Pages
{
    public partial class Home
    {
        [Inject]
        public ApplicationState? ApplicationState { get; set; }

    }
}
