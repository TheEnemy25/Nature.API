using Nature.Infrastructure.Dtos.Base;

namespace Nature.Infrastructure.Dtos
{
    public record AnimalDto : DtoBase
    {
        public string Name { get; init; }
        public string Species { get; init; }
        public string Description { get; init; }
        public string Behavior { get; init; }
        public string PhotoUrl { get; init; }
        public string AudioUrl { get; init; }
    }
}
