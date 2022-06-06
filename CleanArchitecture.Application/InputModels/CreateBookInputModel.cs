using CleanArchitecture.Application.Contracts;

namespace CleanArchitecture.Application.InputModels
{
    public class CreateBookInputModel : IUseCaseInput
    {
        public string Name { get; set; }
        public int Edition { get; set; }
        public int Year { get; set; }
        public string AuthorName { get; set; }
    }
}
