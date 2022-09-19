using TangyModels.LearnBlazorModels;

namespace TangyWeb_Server.Pages.LearnBlazor
{
    public partial class DemoProduct
    {
        private int SelectedFavouriteCount { get; set; } = 0;
        private string LastSelectedProductName { get; set; }
        List<Demo_Product> demo_Products = new();

        protected override void OnInitialized()
        {
            demo_Products.Add(new()
            {
                Id = 1,
                Name = "Midnight Blaze",
                Price = 12.33,
                IsActive = false,
                ProductProperties = new()
                {
                    new Demo_ProductProp { Id = 1, Key = "Flavor", Value = "Rose"},
                    new Demo_ProductProp { Id = 2, Key = "Size", Value = "20oz"},
                    new Demo_ProductProp { Id = 3, Key = "Color", Value="Purple" }
                }
            });

            demo_Products.Add(new()
            {
                Id = 2,
                Name = "Blossom Lily",
                Price = 92.12,
                IsActive = true,
                ProductProperties = new()
            {
                new Demo_ProductProp { Id = 1, Key = "Flavor", Value = "Lily" },
                new Demo_ProductProp { Id = 2, Key = "Size", Value = "18oz" },
                new Demo_ProductProp { Id = 3,Key = "Color",Value = "White"}
            }
            });
        }
        protected void FavouriteCountUpdate(bool isSelected)
        {
            if (isSelected)
            {
                SelectedFavouriteCount++;
            }
            else
            {
                SelectedFavouriteCount--;
            }
        }
        protected void LastProductSelect(string productName)
        {
            LastSelectedProductName = productName;
        }
    }
}
