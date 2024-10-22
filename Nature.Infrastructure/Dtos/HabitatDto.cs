using Nature.Infrastructure.Dtos.Base;

namespace Nature.Infrastructure.Dtos
{
    public record HabitatDto : DtoBase
    {
        public string Name { get; init; }
        public string Location { get; init; }
        public string Type { get; init; }
    }
}
