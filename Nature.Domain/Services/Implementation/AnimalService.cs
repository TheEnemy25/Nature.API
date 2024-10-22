using Nature.Data.Entities;
using Nature.Data.Infrastructure;
using Nature.Domain.Services.BaseService;
using Nature.Domain.Services.Interfaces;

namespace Nature.Domain.Services.Implementation
{
    public class AnimalService : BaseService<Animal>, IAnimalService
    {
        public AnimalService(IBaseRepository<Animal> repository) : base(repository) { }


    }
}
