using TangyModels.LearnBlazorModels;

namespace TangyWeb_Server.Pages.LearnBlazor
{
    public partial class BindProp
    {
        private string _selectedProp = "";

        Demo_Product product = new()
        {
            Id = 1,
            Name = "Rose Candle",
            Price = 10.99,
            IsActive = true,
            ProductProperties = new List<Demo_ProductProp>()
            {
                new Demo_ProductProp{Id = 1, Key = "Color", Value = "Black"},
                new Demo_ProductProp{Id = 2, Key = "Flavour", Value = "Rose Jasmine"},
                new Demo_ProductProp{Id = 3, Key = "Size", Value = "20oz"}
            }
        };

        List<Demo_Product> Products = new();

        protected override void OnInitialized()
        {
            Products.Add(new()
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

            Products.Add(new()
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
    }
}
