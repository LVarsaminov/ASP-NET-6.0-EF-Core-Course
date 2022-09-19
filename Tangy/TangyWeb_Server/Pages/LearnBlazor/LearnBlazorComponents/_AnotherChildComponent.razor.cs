using Microsoft.AspNetCore.Components;

namespace TangyWeb_Server.Pages.LearnBlazor.LearnBlazorComponents
{
    public partial class _AnotherChildComponent
    {
        //[Parameter]
        //public string Placeholder { get; set; } = "Initial Text";
        //[Parameter]
        //public string Required { get; set; } = "required";
        //[Parameter]
        //public string MaxLength { get; set; } = "10";
        [Parameter(CaptureUnmatchedValues =true)]
        public Dictionary<string, object> InputAttributes { get; set; } = new Dictionary<string, object>();
        
    }
}
