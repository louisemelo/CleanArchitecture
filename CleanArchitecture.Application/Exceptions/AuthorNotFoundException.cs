namespace CleanArchitecture.Application.Exceptions
{
    public sealed class AuthorNotFoundException : BaseException
    {
        public AuthorNotFoundException(string message) : base(message)
        {
        }
    }
}
