using AutoMapper;
using Nature.Infrastructure.Dtos;
using Nature.Infrastructure.Entities;

namespace Nature.Infrastructure.MappingProfiles
{
    public sealed class ObservationMappingProfile : Profile
    {
        public ObservationMappingProfile()
        {
            CreateMap<Observation, ObservationDto>();
            CreateMap<ObservationDto, Observation>();
        }
    }
}
