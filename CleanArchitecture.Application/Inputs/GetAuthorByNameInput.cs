using CleanArchitecture.Application.Contracts;

namespace CleanArchitecture.Application.Inputs
{
    public class GetAuthorByNameInput : IUseCaseInput
    {
        public string Name { get; set; }
    }
}
