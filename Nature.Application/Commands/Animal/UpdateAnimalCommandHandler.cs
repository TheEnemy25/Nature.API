using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Nature.Domain.Services.Interfaces;
using Nature.Infrastructure.Dtos;

namespace Nature.Application.Commands.Animal
{
    public record UpdateAnimalCommand(Guid Id, string Name, string Species, string Description, string Behavior, string PhotoUrl, string AudioUrl) : IRequest<AnimalDto>;

    internal sealed class UpdateAnimalCommandHandler : IRequestHandler<UpdateAnimalCommand, AnimalDto>
    {
        private readonly IAnimalService _animalService;
        private readonly IMapper _mapper;
        private readonly ILogger<UpdateAnimalCommandHandler> _logger;

        public UpdateAnimalCommandHandler(IAnimalService animalService, IMapper mapper, ILogger<UpdateAnimalCommandHandler> logger)
        {
            _animalService = animalService;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<AnimalDto> Handle(UpdateAnimalCommand request, CancellationToken cancellationToken)
        {
            var animal = _mapper.Map<AnimalDto>(request);

            _logger.LogInformation($"Update of animal with id {request.Id} begins");

            await _animalService.UpdateAsync(animal, cancellationToken);

            _logger.LogInformation($"Animal with id {request.Id} was successfully updated");

            return animal;
        }
    }
}