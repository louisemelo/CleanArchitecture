using CleanArchitecture.Application.Outputs;

namespace CleanArchitecture.Application.Contracts
{
    public interface IUseCaseQuery<TUseCaseInput> where TUseCaseInput : IUseCaseInput
    {
        ValueTask<BaseOutput> ExecuteTaskAsync(TUseCaseInput input);
    }
}
