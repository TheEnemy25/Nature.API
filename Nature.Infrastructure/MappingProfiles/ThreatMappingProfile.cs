using AutoMapper;
using Nature.Infrastructure.Dtos;
using Nature.Infrastructure.Entities;

namespace Nature.Infrastructure.MappingProfiles
{
    public sealed class ThreatMappingProfile : Profile
    {
        public ThreatMappingProfile()
        {
            CreateMap<Threat, ThreatDto>();
            CreateMap<ThreatDto, Threat>()
                .ForMember(ct => ct.Plants, cfg => cfg.Ignore())
                .ForMember(ct => ct.Animals, cfg => cfg.Ignore());
        }
    }
}
