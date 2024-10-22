using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Nature.Domain.Services.Interfaces;
using Nature.Infrastructure.Dtos;

namespace Nature.Application.Commands.Animal
{
    public record CreateAnimalCommand(string Name, string Species, string Description, string Behavior, string PhotoUrl, string AudioUrl) : IRequest<Guid>;

    internal sealed class CreateAnimalCommandHandler : IRequestHandler<CreateAnimalCommand, Guid>
    {
        private readonly IAnimalService _animalService;
        private readonly IMapper _mapper;
        private readonly ILogger<CreateAnimalCommandHandler> _logger;

        public CreateAnimalCommandHandler(IAnimalService animalService, IMapper mapper, ILogger<CreateAnimalCommandHandler> logger)
        {
            _animalService = animalService;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<Guid> Handle(CreateAnimalCommand request, CancellationToken cancellationToken)
        {
            var animal = _mapper.Map<AnimalDto>(request);

            _logger.LogInformation($"Creation of animal begins");

            var animalId = await _animalService.CreateAsync(animal, cancellationToken);

            _logger.LogInformation($"Creation of animal with id {animalId} was successfull");

            return animalId;
        }
    }
}