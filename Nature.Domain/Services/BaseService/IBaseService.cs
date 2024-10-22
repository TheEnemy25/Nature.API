using Nature.Infrastructure.Dtos.Base;
using Nature.Infrastructure.Entities.Interfaces;

namespace Nature.Domain.Services.BaseService
{
    public interface IBaseService<TEntity, TDto>
        where TEntity : class, IEntityWithId
        where TDto : DtoBase
    {
        Task<IEnumerable<TDto>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<TDto> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
        Task<Guid> CreateAsync(TDto dto, CancellationToken cancellationToken = default);
        Task<TDto> UpdateAsync(TDto dto, CancellationToken cancellationToken = default);
        Task DeleteAsync(Guid id, CancellationToken cancellationToken = default);
    }
}