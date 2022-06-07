using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Interfaces.Repositories;

namespace CleanArchitecture.Infrastructure.Persistence.Repositories
{
    public sealed class AuthorRepository : IAuthorRepository
    {
        private readonly CleanArchitectureContext _context;

        public AuthorRepository(CleanArchitectureContext ctx)
        {
            _context = ctx;
        }

        public async ValueTask AddAuthor(Author author)
        {
            _context.Add(author);
            _context.SaveChanges();
        }

        public async Task<IEnumerable<Author>> GetAllAuthors()
        {
            return _context.Authors;
        }

        public async Task<Author> GetAuthorByName(string name)
        {
            return _context.Authors.Where(w => w.Name == name).FirstOrDefault();
        }
    }
}
