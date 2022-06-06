using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Domain.Interfaces.Repositories
{
    public interface IBookRepository
    {
        void CreateBook(Book book);
    }
}
