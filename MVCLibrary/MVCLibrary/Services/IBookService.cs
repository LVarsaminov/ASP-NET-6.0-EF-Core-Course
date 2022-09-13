using MVCLibrary.Models;

namespace MVCLibrary.Services
{
    public interface IBookService
    {
        Task<Book> GetBookDetails(int? id);
    }
}
