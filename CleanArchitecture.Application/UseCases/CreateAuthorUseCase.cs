using CleanArchitecture.Application.Contracts;
using CleanArchitecture.Application.Exceptions;
using CleanArchitecture.Application.Inputs;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Interfaces.Repositories;

namespace CleanArchitecture.Application.UseCases
{
    public class CreateAuthorUseCase : IUseCaseCommand<CreateAuthorInput>
    {
        private readonly IAuthorRepository _authorRepository;

        public CreateAuthorUseCase(IAuthorRepository authorRepository)
        {
            this._authorRepository = authorRepository;
        }

        public async ValueTask ExecuteTaskAsync(CreateAuthorInput input)
        {
            Author author = await _authorRepository.GetAuthorByName(input.Name).ConfigureAwait(true);

            if (author != null)
                throw new AuthorAlreadyExistsException($"Author with name {input.Name} already exists.");

            author = new Author(input.Name);

            if (!author.IsValid)
                throw new ParametersInvalidsException(string.Join(';', author.Notifications.Select(s => s.Message)));

            await _authorRepository.AddAuthor(author);
        }
    }
}
