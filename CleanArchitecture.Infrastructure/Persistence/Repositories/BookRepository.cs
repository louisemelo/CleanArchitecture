using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Persistence.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly CleanArchitectureContext _context;

        public BookRepository(CleanArchitectureContext ctx)
        {
            _context = ctx;
        }

        public async ValueTask AddBook(Book book)
        {
            _context.Add(book);
            _context.SaveChanges();
        }

        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return _context.Books;
        }

        public async Task<Book> GetBookByName(string name)
        {
            return _context.Books.Where(w => w.Name == name).FirstOrDefault();
        }

    }
}
