using AutoMapper;
using Nature.Data.Infrastructure;
using Nature.Domain.Services.BaseService;
using Nature.Domain.Services.Interfaces;
using Nature.Infrastructure.Dtos;
using Nature.Infrastructure.Entities;

namespace Nature.Domain.Services.Implementation
{
    internal sealed class AnimalService : BaseService<Animal, AnimalDto>, IAnimalService
    {
        public AnimalService(IBaseRepository<Animal> repository, IMapper mapper) : base(repository, mapper) { }


    }
}
