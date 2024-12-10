using MediatR;
using Microsoft.Extensions.Logging;
using Nature.Domain.Services.Interfaces;

namespace Nature.Application.Commands.Plant
{
    public record DeletePlantCommand(Guid Id) : IRequest;

    internal sealed class DeletePlantCommandHandler : IRequestHandler<DeletePlantCommand>
    {
        private readonly IPlantService _plantService;
        private readonly ILogger<DeletePlantCommandHandler> _logger;

        public DeletePlantCommandHandler(IPlantService plantService, ILogger<DeletePlantCommandHandler> logger)
        {
            _plantService = plantService;
            _logger = logger;
        }

        public async Task Handle(DeletePlantCommand request, CancellationToken cancellationToken)
        {
            var plant = request.Id;

            _logger.LogInformation($"Deletion of plant with id {plant} begins");

            await _plantService.DeleteAsync(plant, cancellationToken);

            _logger.LogInformation($"Plant with id {plant} was successfully deleted");
        }
    }
}
