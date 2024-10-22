namespace Nature.Infrastructure.Dtos.Base
{
    public abstract record DtoBase
    {
        public Guid Id { get; init; }
    }
}
