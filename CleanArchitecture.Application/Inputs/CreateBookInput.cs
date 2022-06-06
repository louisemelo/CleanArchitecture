using CleanArchitecture.Application.Contracts;

namespace CleanArchitecture.Application.Inputs
{
    public sealed class CreateBookInput : IUseCaseInput
    {
        public string Name { get; set; }
        public int Edition { get; set; }
        public int Year { get; set; }
        public string AuthorName { get; set; }
    }
}
