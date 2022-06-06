using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Domain.Interfaces.Repositories
{
    public interface IBookRepository
    {
        List<Book> GetAllBooks();
        Book GetBook(int id);
    }
}
