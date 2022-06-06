using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.OutputModels;
using CleanArchitecture.Domain.Interfaces.Repositories;

namespace CleanArchitecture.Application.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            this._bookRepository = bookRepository;
        }

        public List<BookOutput> GetAllBooks()
        {
            var books = _bookRepository.GetAllBooks();

            if (books != null)
            {
                return books.Select(s => new BookOutput(s.Name, s.Author, s.Edition, s.Year)).ToList();
            }

            return null;
        }

        public BookOutput GetBookById(int id)
        {
            var book = _bookRepository.GetBook(id);

            if (book != null)
            {
                return new BookOutput(book.Name, book.Author, book.Edition, book.Year);
            }

            return null;
        }
    }
}
