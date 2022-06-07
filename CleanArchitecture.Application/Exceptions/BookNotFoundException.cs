namespace CleanArchitecture.Application.Exceptions
{
    public sealed class BookNotFoundException : BaseException
    {
        public BookNotFoundException(string message) : base(message)
        {
        }
    }
}
