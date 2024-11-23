using AutoMapper;
using Nature.Infrastructure.Dtos;
using Nature.Infrastructure.Entities;

namespace Nature.Infrastructure.MappingProfiles
{
    public sealed class PlantMappingProfile : Profile
    {
        public PlantMappingProfile()
        {
            CreateMap<Plant, PlantDto>();
            CreateMap<PlantDto, Plant>()
                .ForMember(ct => ct.Threats, cfg => cfg.Ignore())
                .ForMember(ct => ct.Safekeepings, cfg => cfg.Ignore());
        }
    }
}
