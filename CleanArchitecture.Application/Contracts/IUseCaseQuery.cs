namespace CleanArchitecture.Application.Contracts
{
    public interface IUseCaseQuery<TUseCaseInput> where TUseCaseInput : IUseCaseInput
    {
        ValueTask<T> ExecuteTaskAsync<T>(TUseCaseInput input);
    }
}
