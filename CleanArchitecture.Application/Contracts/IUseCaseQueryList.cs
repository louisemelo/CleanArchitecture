using CleanArchitecture.Application.Outputs;

namespace CleanArchitecture.Application.Contracts
{
    public interface IUseCaseQueryList<TUseCaseInput> where TUseCaseInput : IUseCaseInput
    {
        ValueTask<BaseOutput> ExecuteTaskAsync();
    }
}
