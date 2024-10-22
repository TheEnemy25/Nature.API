using Nature.Domain.Services.BaseService;
using Nature.Infrastructure.Dtos;
using Nature.Infrastructure.Entities;

namespace Nature.Domain.Services.Interfaces
{
    public interface IAnimalService : IBaseService<Animal, AnimalDto>
    {
    }
}
