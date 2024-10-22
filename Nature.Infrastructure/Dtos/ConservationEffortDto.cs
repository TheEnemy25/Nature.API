using Nature.Infrastructure.Dtos.Base;

namespace Nature.Infrastructure.Dtos
{
    public record ConservationEffortDto : DtoBase
    {
        public string Name { get; init; }
        public string Description { get; init; }
    }
}
