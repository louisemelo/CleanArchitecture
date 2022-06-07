using CleanArchitecture.Application.Contracts;

namespace CleanArchitecture.Application.Inputs
{
    public class CreateAuthorInput : IUseCaseInput
    {
        public string Name { get; set; }
    }
}
