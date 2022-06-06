using CleanArchitecture.Application.Contracts;
using CleanArchitecture.Application.Exceptions;
using CleanArchitecture.Application.Inputs;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Interfaces.Repositories;

namespace CleanArchitecture.Application.UseCases
{
    public sealed class CreateBookUseCase : IUseCase<CreateBookInput>
    {
        private readonly IBookRepository _bookRepository;
        private readonly IAuthorRepository _authorRepository;

        public CreateBookUseCase(IBookRepository bookRepository, IAuthorRepository authorRepository)
        {
            this._bookRepository = bookRepository;
            this._authorRepository = authorRepository;
        }

        public async ValueTask ExecuteTaskAsync(CreateBookInput input)
        {
            var author = await _authorRepository.GetAuthorByName(input.AuthorName).ConfigureAwait(true);

            if (author == null)
                throw new AuthorNotFoundException("No author found for the given name. Author registration required to add a book.");

            var book = new Book(input.Name, author, input.Edition, input.Year);
        }
    }
}
