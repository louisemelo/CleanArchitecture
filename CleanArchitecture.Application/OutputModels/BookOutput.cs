namespace CleanArchitecture.Application.OutputModels
{
    public class BookOutput
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int Edition { get; set; }
        public int Year { get; set; }

        public BookOutput(string name, string author, int edition, int year)
        {
            Name = name;
            Author = author;
            Edition = edition;
            Year = year;
        }
    }
}
