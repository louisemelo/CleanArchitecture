using Flunt.Validations;

namespace CleanArchitecture.Domain.Entities
{
    public sealed class Author : BaseEntity
    {
        public Author(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
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
