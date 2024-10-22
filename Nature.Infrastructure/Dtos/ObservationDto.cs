using Nature.Infrastructure.Dtos.Base;

namespace Nature.Infrastructure.Dtos
{
    public record ObservationDto : DtoBase
    {
        public DateTime Date { get; init; }
        public string Notes { get; init; }
    }
}
