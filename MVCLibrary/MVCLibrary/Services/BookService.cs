using Microsoft.CodeAnalysis.Operations;
using Microsoft.EntityFrameworkCore;
using MVCLibrary.Data;
using MVCLibrary.Data.Repositories;
using MVCLibrary.Models;

namespace MVCLibrary.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository repository;

        public BookService(IBookRepository repository)
        {
            this.repository = repository;
        }
        public async Task<Book> GetBookDetails(int? id)
        {
            var book = await this.repository.GetById(id);

            return book != null ? book : new Book();
        }
    }
}
