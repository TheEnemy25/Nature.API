using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Nature.Domain.Services.Interfaces;
using Nature.Infrastructure.Dtos;

namespace Nature.Application.Commands.Plant
{
    public record CreatePlantCommand(string Name, string Species, string Description, string PhotoUrl) : IRequest<Guid>;

    internal sealed class CreatePlantCommandHandler : IRequestHandler<CreatePlantCommand, Guid>
    {
        private readonly IPlantService _plantService;
        private readonly IMapper _mapper;
        private readonly ILogger<CreatePlantCommand> _logger;

        public CreatePlantCommandHandler(IPlantService plantService, IMapper mapper, ILogger<CreatePlantCommand> logger)
        {
            _plantService = plantService;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<Guid> Handle(CreatePlantCommand request, CancellationToken cancellationToken)
        {
            var plant = _mapper.Map<PlantDto>(request);

            _logger.LogInformation($"Creation of plant begins");

            var plantId = await _plantService.CreateAsync(plant, cancellationToken);

            _logger.LogInformation($"Creation of plant with id {plantId} was successfull");

            return plantId;
        }
    }
}
