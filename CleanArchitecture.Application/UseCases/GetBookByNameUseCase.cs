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

        public async ValueTask<T> ExecuteTaskAsync<T>(GetBookByNameInput input)
        {
            if (string.IsNullOrEmpty(input.Name))
                throw new ParametersInvalidsException("Filter 'Name' is required.");

            var book = await _bookRepository.GetBookByName(input.Name).ConfigureAwait(true);

            if (book == null)
                throw new BookNotFoundException($"Author {input.Name} not found.");

            return (T)Convert.ChangeType(await Task.Run(async () => new GetBookByNameInput()).ConfigureAwait(true), typeof(T));
        }
    }
}
