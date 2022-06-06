using CleanArchitecture.Application.Contracts;

namespace CleanArchitecture.Application.Inputs
{
    public sealed class CreateAuthorInput : IUseCaseInput
    {
        public string Name { get; set; }
    }
}
