namespace CleanArchitecture.Application.Exceptions
{
    public class AuthorAlreadyExistsException : BaseException
    {
        public AuthorAlreadyExistsException(string message) : base(message)
        {
        }
    }
}
