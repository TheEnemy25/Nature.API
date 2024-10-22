using AutoMapper;
using Nature.Application.Commands.Animal;
using Nature.Infrastructure.Dtos;

namespace Nature.Application.MappingProfiles
{
    internal class AnimalRequestsMappingProfile : Profile
    {
        public AnimalRequestsMappingProfile()
        {
            CreateMap<CreateAnimalCommand, AnimalDto>();
            CreateMap<UpdateAnimalCommand, AnimalDto>();
        }
    }
}
