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
        private readonly List<Book> Books;

        public BookRepository()
        {
            Books = new List<Book>();

            Books.Add(new Book { Id = 1, Name = "Clean Achitecture", Author = "Robert C. Martin", Edition = 1, Year = 2017 });
            Books.Add(new Book { Id = 2, Name = "Clean Code", Author = "Robert C. Martin", Edition = 1, Year = 2009 });
            Books.Add(new Book { Id = 3, Name = "Domain-Drive Design - Trackling Complexity in the Heart of Software", Author = "Eric Evans", Edition = 3, Year = 2003 });
        }
        public List<Book> GetAllBooks()
        {
            return Books;
        }

        public Book GetBook(int id)
        {
            return Books.Where(w => w.Id == id).FirstOrDefault();
        }
    }
}
