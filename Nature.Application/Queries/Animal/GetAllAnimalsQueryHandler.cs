using MediatR;
using Microsoft.Extensions.Logging;
using Nature.Domain.Services.Interfaces;
using Nature.Infrastructure.Dtos;

namespace Nature.Application.Queries.Animal
{
    public record GetAllAnimalsQuery : IRequest<IEnumerable<AnimalDto>>;

    internal sealed class GetAllAnimalsQueryHandler : IRequestHandler<GetAllAnimalsQuery, IEnumerable<AnimalDto>>
    {
        private readonly IAnimalService _animalService;
        private readonly ILogger<GetAllAnimalsQueryHandler> _logger;

        public GetAllAnimalsQueryHandler(IAnimalService animalService, ILogger<GetAllAnimalsQueryHandler> logger)
        {
            _animalService = animalService;
            _logger = logger;
        }

        public async Task<IEnumerable<AnimalDto>> Handle(GetAllAnimalsQuery request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Retrieving all animals");

            var animals = await _animalService.GetAllAsync(cancellationToken);

            _logger.LogInformation("Retrieved all animals successfully");

            return animals;
        }
    }
}
