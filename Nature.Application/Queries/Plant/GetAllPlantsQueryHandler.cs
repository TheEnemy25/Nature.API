using MediatR;
using Microsoft.Extensions.Logging;
using Nature.Domain.Services.Interfaces;
using Nature.Infrastructure.Dtos;

namespace Nature.Application.Queries.Plant
{
    public record GetAllPlantsQuery : IRequest<IEnumerable<PlantDto>>;

    internal sealed class GetAllPlantsQueryHandler : IRequestHandler<GetAllPlantsQuery, IEnumerable<PlantDto>>
    {
        private readonly IPlantService _plantService;
        private readonly ILogger<GetAllPlantsQueryHandler> _logger;

        public GetAllPlantsQueryHandler(IPlantService plantService, ILogger<GetAllPlantsQueryHandler> logger)
        {
            _plantService = plantService;
            _logger = logger;
        }

        public async Task<IEnumerable<PlantDto>> Handle(GetAllPlantsQuery request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Retrieving all plants");

            var plants = await _plantService.GetAllAsync(cancellationToken);

            _logger.LogInformation("Retrieved all plants successfully");

            return plants;
        }
    }
}
