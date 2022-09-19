using Microsoft.AspNetCore.Components;

namespace TangyWeb_Server.Pages.LearnBlazor.LearnBlazorComponents
{
    public partial class _GrandChildComponent
    {
        [CascadingParameter(Name ="Message")]
        public string MessageForGrandChild { get; set; }
        [CascadingParameter(Name ="LuckyNumber")]
        public string LuckyNumberForGrandChild { get; set; }
    }
}
