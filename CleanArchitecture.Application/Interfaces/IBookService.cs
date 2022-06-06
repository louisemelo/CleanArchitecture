using CleanArchitecture.Application.OutputModels;

namespace CleanArchitecture.Application.Interfaces
{
    public interface IBookService
    {
        List<BookOutput> GetAllBooks();
        BookOutput GetBookById(int id);
    }
}
