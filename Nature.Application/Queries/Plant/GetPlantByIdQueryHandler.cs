using MediatR;
using Microsoft.Extensions.Logging;
using Nature.Domain.Services.Interfaces;
using Nature.Infrastructure.Dtos;

namespace Nature.Application.Queries.Plant
{
    public record GetPlantByIdQuery(Guid Id) : IRequest<PlantDto>;

    internal sealed class GetPlantByIdQueryHandler : IRequestHandler<GetPlantByIdQuery, PlantDto>
    {
        private readonly IPlantService _plantService;
        private readonly ILogger<GetPlantByIdQueryHandler> _logger;

        public GetPlantByIdQueryHandler(IPlantService plantService, ILogger<GetPlantByIdQueryHandler> logger)
        {
            _plantService = plantService;
            _logger = logger;
        }

        public async Task<PlantDto> Handle(GetPlantByIdQuery request, CancellationToken cancellationToken)
        {
            return await _plantService.GetByIdAsync(request.Id, cancellationToken);
        }
    }
}
