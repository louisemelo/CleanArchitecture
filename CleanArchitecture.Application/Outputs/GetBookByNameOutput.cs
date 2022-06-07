namespace CleanArchitecture.Application.Outputs
{
    public class GetBookByNameOutput : BaseOutput
    {
        public Guid? Id { get; set; }
        public string? Name { get; set; }
        public string Author { get; set; }
        public int Edition { get; set; }
        public int Year { get; set;
        }
        public GetBookByNameOutput()
        {
        }

        public GetBookByNameOutput(string message) : base(message)
        {
        }

        public GetBookByNameOutput(string message, bool hasError) : base(message, hasError)
        {
        }

        public GetBookByNameOutput(Guid? id, string? name, string author, int edition, int year)
        {
            Id = id;
            Name = name;
            Author = author;
            Edition = edition;
            Year = year;
        }
    }
}
