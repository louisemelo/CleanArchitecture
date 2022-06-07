using CleanArchitecture.Application.Contracts;
using CleanArchitecture.Application.Exceptions;
using CleanArchitecture.Application.Inputs;
using CleanArchitecture.Application.Outputs;
using CleanArchitecture.Domain.Interfaces.Repositories;

namespace CleanArchitecture.Application.UseCases
{
    internal class GetAuthorByNameUseCase : IUseCaseQuery<GetAuthorByNameInput>
    {
        private readonly IAuthorRepository _authorRepository;

        public GetAuthorByNameUseCase(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public async ValueTask<BaseOutput> ExecuteTaskAsync(GetAuthorByNameInput input)
        {
            if (string.IsNullOrEmpty(input.Name))
                throw new ParametersInvalidsException("Filter 'Name' is required.");

            var author = await _authorRepository.GetAuthorByName(input.Name).ConfigureAwait(true);

            if (author == null)
                throw new AuthorNotFoundException($"Author {input.Name} not found.");

            var result = new BaseOutput() { _result = new GetAuthorByNameOutput(author.Id, author.Name) };

            return result;
        }
    }
}
