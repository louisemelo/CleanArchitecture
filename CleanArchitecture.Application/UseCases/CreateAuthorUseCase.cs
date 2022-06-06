using CleanArchitecture.Application.Contracts;
using CleanArchitecture.Application.Inputs;
using CleanArchitecture.Domain.Interfaces.Repositories;

namespace CleanArchitecture.Application.UseCases
{
    public sealed class CreateAuthorUseCase : IUseCase<CreateAuthorInput>
    {
        private readonly IAuthorRepository _authorRepository;

        public CreateAuthorUseCase(IAuthorRepository authorRepository)
        {
            this._authorRepository = authorRepository;
        }

        public ValueTask ExecuteTaskAsync(CreateAuthorInput input)
        {
            throw new NotImplementedException();
        }
    }
}
