using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Domain.Interfaces.Repositories
{
    public interface IAuthorRepository
    {
        Task<Author> GetAuthorByName(string name);
        ValueTask AddAuthor(Author author);
    }
}
