using AutoMapper;
using Nature.Application.Commands.Plant;
using Nature.Infrastructure.Dtos;

namespace Nature.Application.MappingProfiles
{
    internal class PlantRequestsMappingProfile : Profile
    {
        public PlantRequestsMappingProfile()
        {
            CreateMap<CreatePlantCommand, PlantDto>();
            CreateMap<UpdatePlantCommand, PlantDto>();
        }
    }
}
