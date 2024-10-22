using MediatR;
using Microsoft.Extensions.Logging;
using Nature.Domain.Services.Interfaces;
using Nature.Infrastructure.Dtos;

namespace Nature.Application.Queries.Animal
{
    public record GetAnimalByIdQuery(Guid Id) : IRequest<AnimalDto>;

    internal sealed class GetAnimalByIdQueryHandler : IRequestHandler<GetAnimalByIdQuery, AnimalDto>
    {
        private readonly IAnimalService _animalService;
        private readonly ILogger<GetAnimalByIdQueryHandler> _logger;

        public GetAnimalByIdQueryHandler(IAnimalService animalService, ILogger<GetAnimalByIdQueryHandler> logger)
        {
            _animalService = animalService;
            _logger = logger;
        }

        public async Task<AnimalDto> Handle(GetAnimalByIdQuery request, CancellationToken cancellationToken)
        {
            return await _animalService.GetByIdAsync(request.Id, cancellationToken);
        }
    }
}
