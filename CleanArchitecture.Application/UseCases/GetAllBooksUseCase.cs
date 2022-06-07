using CleanArchitecture.Application.Contracts;
using CleanArchitecture.Application.Exceptions;
using CleanArchitecture.Application.Inputs;
using CleanArchitecture.Application.Outputs;
using CleanArchitecture.Domain.Interfaces.Repositories;

namespace CleanArchitecture.Application.UseCases
{
    internal class GetAllBooksUseCase : IUseCaseQueryList<BaseInput>
    {
        private readonly IBookRepository _bookRepository;

        public GetAllBooksUseCase(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async ValueTask<BaseOutput> ExecuteTaskAsync()
        {
            var books = await _bookRepository.GetAllBooks().ConfigureAwait(true);

            if (books == null)
                throw new BookNotFoundException($"Books not found.");

            var booksResult = books.Select(s => new GetBooksOutput(s.Name, s.Author.Name, s.Edition, s.Year)).ToList();

            var result = new BaseOutput() { _result = booksResult };

            return result;
        }
    }
}
