namespace CleanArchitecture.Application.Contracts
{
    public interface IUseCaseCommand<TUseCaseInput> where TUseCaseInput : IUseCaseInput
    {
        ValueTask ExecuteTaskAsync(TUseCaseInput input);
    }

}
