using AutoMapper;
using Nature.Data.Infrastructure;
using Nature.Domain.Services.BaseService;
using Nature.Domain.Services.Interfaces;
using Nature.Infrastructure.Dtos;
using Nature.Infrastructure.Entities;

namespace Nature.Domain.Services.Implementation
{
    internal sealed class PlantService : BaseService<Plant, PlantDto>, IPlantService
    {
        public PlantService(IBaseRepository<Plant> repository, IMapper mapper) : base(repository, mapper) { }


    }
}
