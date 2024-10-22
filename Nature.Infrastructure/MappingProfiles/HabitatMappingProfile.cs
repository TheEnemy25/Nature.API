using AutoMapper;
using Nature.Infrastructure.Dtos;
using Nature.Infrastructure.Entities;

namespace Nature.Infrastructure.MappingProfiles
{
    public sealed class HabitatMappingProfile : Profile
    {
        public HabitatMappingProfile()
        {
            CreateMap<Habitat, HabitatDto>();
            CreateMap<HabitatDto, Habitat>()
                 .ForMember(ct => ct.Plants, cfg => cfg.Ignore())
                 .ForMember(ct => ct.Animals, cfg => cfg.Ignore());
        }
    }
}
