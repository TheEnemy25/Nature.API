using Nature.Data.Entities;
using Nature.Data.Infrastructure;
using Nature.Domain.Services.BaseService;
using Nature.Domain.Services.Interfaces;

namespace Nature.Domain.Services.Implementation
{
    public class PlantService : BaseService<Plant>, IPlantService
    {
        public PlantService(IBaseRepository<Plant> repository) : base(repository) { }


    }
}
