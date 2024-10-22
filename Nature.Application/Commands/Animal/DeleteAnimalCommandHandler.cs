using MediatR;
using Microsoft.Extensions.Logging;
using Nature.Domain.Services.Interfaces;

namespace Nature.Application.Commands.Animal
{
    public record DeleteAnimalCommand(Guid Id) : IRequest;

    internal sealed class DeleteAnimalCommandHandler : IRequestHandler<DeleteAnimalCommand>
    {
        private readonly IAnimalService _animalService;
        private readonly ILogger<DeleteAnimalCommandHandler> _logger;

        public DeleteAnimalCommandHandler(IAnimalService animalService, ILogger<DeleteAnimalCommandHandler> logger)
        {
            _animalService = animalService;
            _logger = logger;
        }

        public async Task Handle(DeleteAnimalCommand request, CancellationToken cancellationToken)
        {
            var animal = request.Id;

            _logger.LogInformation($"Deletion of animal with id {animal} begins");

            await _animalService.DeleteAsync(animal, cancellationToken);

            _logger.LogInformation($"Animal with id {animal} was successfully deleted");
        }
    }
}
