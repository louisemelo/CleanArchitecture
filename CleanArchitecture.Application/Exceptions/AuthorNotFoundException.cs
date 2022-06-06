namespace CleanArchitecture.Application.Exceptions
{
    public sealed class AuthorNotFoundException : Exception
    {
        public string Message { get; set; }

        public AuthorNotFoundException(string message)
        {
            this.Message = message;
        }
    }
}
