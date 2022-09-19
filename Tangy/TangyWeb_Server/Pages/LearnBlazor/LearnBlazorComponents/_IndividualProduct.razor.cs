using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components;
using TangyModels.LearnBlazorModels;

namespace TangyWeb_Server.Pages.LearnBlazor.LearnBlazorComponents
{
    public partial class _IndividualProduct
    {

        [Parameter]
        public Demo_Product Product { get; set; }
        [Parameter]
        public EventCallback<bool> OnFavouriteUpdate { get; set; }
        [Parameter]
        public EventCallback<string> OnLastSelectedProductChange { get; set; }
        [Parameter]
        public RenderFragment FirstFragment { get; set; }
        [Parameter]
        public RenderFragment SecondFragment { get; set; }
        private async Task FavouriteUpdate(ChangeEventArgs e)
        {
            await OnFavouriteUpdate.InvokeAsync((bool)e.Value);
        }
        private async Task LastSelectedProduct(MouseEventArgs e, string name)
        {
            await OnLastSelectedProductChange.InvokeAsync(name);
        }
    }
}
