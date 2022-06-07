namespace CleanArchitecture.Application.Outputs
{
    public class GetBooksOutput : BaseOutput
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int Edition { get; set; }
        public int Year { get; set; }

        public GetBooksOutput(string name, string author, int edition, int year)
        {
            Name = name;
            Author = author;
            Edition = edition;
            Year = year;
        }

        public GetBooksOutput()
        {
        }

        public GetBooksOutput(string message, bool hasError) : base(message, hasError)
        {
        }

        public GetBooksOutput(string message) : base(message)
        {
        }
    }
}
