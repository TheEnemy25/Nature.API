using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Nature.Application.Commands.Animal;
using Nature.Domain.Services.Interfaces;
using Nature.Infrastructure.Dtos;

namespace Nature.Application.Commands.Plant
{
    public record UpdatePlantCommand(Guid Id, string Name, string Species, string Description, string PhotoUrl) : IRequest<PlantDto>;

    internal sealed class UpdatePlantCommandHandler : IRequestHandler<UpdatePlantCommand, PlantDto>
    {
        private readonly IPlantService _plantService;
        private readonly IMapper _mapper;
        private readonly ILogger<UpdatePlantCommandHandler> _logger;

        public UpdatePlantCommandHandler(IPlantService plantService, IMapper mapper, ILogger<UpdatePlantCommandHandler> logger)
        {
            _plantService = plantService;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<PlantDto> Handle(UpdatePlantCommand request, CancellationToken cancellationToken)
        {
            var plant = _mapper.Map<PlantDto>(request);

            _logger.LogInformation($"Update of plant with id {request.Id} begins");

            await _plantService.UpdateAsync(plant, cancellationToken);

            _logger.LogInformation($"Plant with id {request.Id} was successfully updated");

            return plant;
        }
    }
}
