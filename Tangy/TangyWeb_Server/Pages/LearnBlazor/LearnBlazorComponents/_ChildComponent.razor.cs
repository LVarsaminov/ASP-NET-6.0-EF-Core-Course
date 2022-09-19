using Microsoft.AspNetCore.Components;

namespace TangyWeb_Server.Pages.LearnBlazor.LearnBlazorComponents
{
    public partial class _ChildComponent
    {
        [Parameter]
        public string Title { get; set; }
        [Parameter]
        public RenderFragment ChildContent { get; set; }
        [Parameter]
        public RenderFragment DangerChildContent { get; set; }
        [Parameter]
        public EventCallback OnButtonClick { get; set; }
    }
}
