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

        
        public void CreateBook(Book book)
        {
            throw new NotImplementedException();
        }

     
    }
}
