using Microsoft.AspNetCore.Components;

namespace TangyWeb_Server.Pages.LearnBlazor
{
    public partial class LearnRouting
    {
        [Parameter]
        public string Parameter1 { get; set; }
        [Parameter]
        public string Parameter2 { get; set; }
        public string Param1 { get; set; }
        public string Param2 { get; set; }
        private void LoadParameters()
        {
            var absoluteUri = new Uri(_NavigationManager.Uri);
            var queryParam  = System.Web.HttpUtility.ParseQueryString(absoluteUri.Query);
            Param1 = queryParam["Param1"];
            Param2 = queryParam["Param2"];
        }
    }
}
