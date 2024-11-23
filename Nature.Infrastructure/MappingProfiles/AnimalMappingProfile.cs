using AutoMapper;
using Nature.Infrastructure.Dtos;
using Nature.Infrastructure.Entities;

namespace Nature.Infrastructure.MappingProfiles
{
    public sealed class AnimalMappingProfile : Profile
    {
        public AnimalMappingProfile()
        {
            CreateMap<Animal, AnimalDto>();
            CreateMap<AnimalDto, Animal>()
                .ForMember(ct => ct.Threats, cfg => cfg.Ignore())
                .ForMember(ct => ct.Safekeepings, cfg => cfg.Ignore());
        }
    }
}
