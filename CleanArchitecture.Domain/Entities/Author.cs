using Flunt.Validations;

namespace CleanArchitecture.Domain.Entities
{
    public sealed class Author : BaseEntity
    {
        public Author() { }
        public Author(string name)
        {
            Name = name;
            AddNotifications();
        }

        public string Name { get; private set; }
        public List<Book> Bookds { get; private set; }
    }

    internal class AuthorValidation : Contract<Author>
    {
        public AuthorValidation(Book book)
        {
            Requires()
                .IsNotNullOrWhiteSpace(book.Name, "Name", "Name is required");
        }
    }
}
