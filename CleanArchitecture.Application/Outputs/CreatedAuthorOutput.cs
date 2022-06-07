namespace CleanArchitecture.Application.Outputs
{
    public class CreatedAuthorOutput : BaseOutput
    {
        public CreatedAuthorOutput(string message) : base(message)
        {
        }

        public CreatedAuthorOutput(string message, bool hasError) : base(message, hasError)
        {
        }
    }
}
