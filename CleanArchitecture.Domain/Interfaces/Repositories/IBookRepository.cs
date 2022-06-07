using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Domain.Interfaces.Repositories
{
    public interface IBookRepository
    {
        ValueTask AddBook(Book book);
        Task<IEnumerable<Book>> GetAllBooks();
        Task<Book> GetBookByName(string name);
    }
}
