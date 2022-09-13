using MVCLibrary.Models;

namespace MVCLibrary.Data.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly LibraryContext context;

        public BookRepository(LibraryContext context)
        {
            this.context = context;
        }
        public Task<int> Create(Book book)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task Edit(Book book)
        {
            throw new NotImplementedException();
        }

        public Task<List<Book>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Book> GetById(int? id)
        {
            throw new NotImplementedException();
        }
    }
}
