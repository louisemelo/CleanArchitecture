using CleanArchitecture.Application.Contracts;

namespace CleanArchitecture.Application.Inputs
{
    public class GetBookByNameInput : IUseCaseInput
    {
        public string Name { get; set; }
    }
}
