using MVCLibrary.Models;

namespace MVCLibrary.Data.Repositories
{
    public interface IBookRepository
    {
        Task<List<Book>> GetAll();

        Task<Book> GetById(int? id);

        Task<int> Create(Book book);

        Task Delete(int id);

        Task Edit(Book book);
    }
}
