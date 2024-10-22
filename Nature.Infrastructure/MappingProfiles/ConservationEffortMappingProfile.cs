using AutoMapper;
using Nature.Infrastructure.Dtos;
using Nature.Infrastructure.Entities;

namespace Nature.Infrastructure.MappingProfiles
{
    public sealed class ConservationEffortMappingProfile : Profile
    {
        public ConservationEffortMappingProfile()
        {
            CreateMap<ConservationEffort, ConservationEffortDto>();
            CreateMap<ConservationEffortDto, ConservationEffort>();
        }
    }
}
