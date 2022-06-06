using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Interfaces.Repositories;

namespace CleanArchitecture.Infrastructure.Persistence.Repositories
{
    public sealed class AuthorRepository : IAuthorRepository
    {
        public async ValueTask AddAuthor(Author author)
        {
            throw new NotImplementedException();
        }

        public async Task<Author> GetAuthorByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
