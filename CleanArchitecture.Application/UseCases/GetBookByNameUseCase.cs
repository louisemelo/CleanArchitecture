using CleanArchitecture.Application.Contracts;
using CleanArchitecture.Application.Exceptions;
using CleanArchitecture.Application.Inputs;
using CleanArchitecture.Application.Outputs;
using CleanArchitecture.Domain.Interfaces.Repositories;

namespace CleanArchitecture.Application.UseCases
{
    internal class GetBookByNameUseCase : IUseCaseQuery<GetBookByNameInput>
    {
        private readonly IBookRepository _bookRepository;

        public GetBookByNameUseCase(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async ValueTask<BaseOutput> ExecuteTaskAsync(GetBookByNameInput input)
        {
            if (string.IsNullOrEmpty(input.Name))
                throw new ParametersInvalidsException("Filter 'Name' is required.");

            var book = await _bookRepository.GetBookByName(input.Name).ConfigureAwait(true);

            if (book == null)
                throw new BookNotFoundException($"Book {input.Name} not found.");

            var result = new BaseOutput() { _result = new GetBooksOutput(book.Name, book.Author.Name, book.Edition, book.Year) };

            return result;
        }
    }
}
