using Microsoft.EntityFrameworkCore;
using Nature.Data.Entities.Interfaces;
using Nature.Data.Exceptions;
using Nature.Data.Infrastructure;

namespace Nature.Domain.Services.BaseService
{
    public abstract class BaseService<TEntity> : IBaseService<TEntity>
       where TEntity : class, IEntity
    {
        protected readonly IBaseRepository<TEntity> _repository;

        public BaseService(IBaseRepository<TEntity> repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await _repository.Query().ToListAsync(cancellationToken);
        }

        public async Task<TEntity> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<Guid> CreateAsync(TEntity entity, CancellationToken cancellationToken = default)
        {
            await _repository.AddAsync(entity, cancellationToken);
            await _repository.SaveChangesAsync(cancellationToken);

            return entity.Id;
        }

        public async Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken = default)
        {
            var existingEntity = await _repository.GetByIdAsync(entity.Id);

            if (existingEntity == null)
            {
                throw new EntityNotFoundException($"{typeof(TEntity).Name} was not found");
            }

            await _repository.DetachAsync(existingEntity);

            await _repository.UpdateAsync(entity, cancellationToken);
            await _repository.SaveChangesAsync(cancellationToken);

            return entity;
        }

        public async Task DeleteAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var entityToDelete = await _repository.GetByIdAsync(id);

            if (entityToDelete == null)
            {
                throw new EntityNotFoundException($"Entity with id {id} was not found");
            }

            await _repository.DeleteAsync(entityToDelete, cancellationToken);
            await _repository.SaveChangesAsync(cancellationToken);
        }
    }
}
