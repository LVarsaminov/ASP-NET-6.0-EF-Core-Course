using Microsoft.EntityFrameworkCore;
using MVCLibrary.Data;

namespace MVCLibrary.Models
{
    public class SeedData 
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context=new LibraryContext
                (serviceProvider.GetRequiredService<DbContextOptions<LibraryContext>>()))
            {
                if (context.Book.Any())
                {
                    return;
                }
                context.Book.AddRange
                    (
                    new Book { Title = "Tiny C# Projects", Author = "Udemy", CallNumber = "AWK 2029" },
                    new Book { Title = "Tiny Android Projects",Author = "Samsung", CallNumber =  "AKQ 2923" }
                    );
                context.SaveChanges();
            }
        }
    }
}
