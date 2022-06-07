using CleanArchitecture.Application.Contracts;

namespace CleanArchitecture.Application.Outputs
{
    public class BaseOutput : IUseCaseOutput
    {
        public BaseOutput() { }

        public BaseOutput(string message, bool hasError)
        {
            Message = message;
            HasError = hasError;
        }

        public BaseOutput(string message)
        {
            Message = message;
        }

        public string Message { get; set; }
        public bool HasError { get; set; }
    }
}
