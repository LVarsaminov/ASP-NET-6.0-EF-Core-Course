namespace TangyWeb_Server.Pages.LearnBlazor
{
    public partial class ParentComponent
    {
        public string messageForGrandChild = "This message is from your grand parent (ParentComponent)";
        public string luckyNumber = "7";
        public string message = "";
        public void ShowMessage()
        {
            message = "Tangy button clicked from Child Component";
        }
    }
}
