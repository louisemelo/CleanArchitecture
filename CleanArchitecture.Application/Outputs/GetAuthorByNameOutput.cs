namespace CleanArchitecture.Application.Outputs
{
    public sealed class GetAuthorByNameOutput : BaseOutput
    {
        public Guid? Id { get; set; }
        public string? Name { get; set; }

        public GetAuthorByNameOutput(string message) : base(message)
        {
        }

        public GetAuthorByNameOutput(string message, bool hasError) : base(message, hasError)
        {
        }

        public GetAuthorByNameOutput(Guid id, string name) : base()
        {
            Id = id;
            Name = name;
        }

        public GetAuthorByNameOutput() { }
    }
}
