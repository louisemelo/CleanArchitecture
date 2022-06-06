namespace CleanArchitecture.Application.Contracts
{
    public interface IUseCase<TUseCaseInput> where TUseCaseInput : IUseCaseInput
    {
        ValueTask ExecuteTaskAsync(TUseCaseInput input);
    }
}
