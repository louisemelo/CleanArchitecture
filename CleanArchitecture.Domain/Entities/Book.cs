using Flunt.Validations;

namespace CleanArchitecture.Domain.Entities
{
    public class Book : BaseEntity
    {
        public Book(string name, Author author, int edition, int year)
        {
            Name = name;
            Author = author;
            Edition = edition;
            Year = year;
        }

        public string Name { get; private set; }
        public Author Author { get; private set; }
        public int Edition { get; private set; }
        public int Year { get; private set; }
    }

    internal class BookValidation : Contract<Book>
    {
        public BookValidation(Book book)
        {
            Requires()
                .IsNotNullOrWhiteSpace(book.Name, "Name", "Name is required")
                .IsNotNull(book.Author, "Author", "Author is required")
                .IsGreaterThan(0, book.Edition, "Edition", "Edition must be greater than zero")
                .IsGreaterThan(1979, book.Year, "Year", "Year must be greater than 1979");
        }
    }
}
