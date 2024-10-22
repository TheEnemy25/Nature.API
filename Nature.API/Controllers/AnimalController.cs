using Microsoft.AspNetCore.Mvc;
using Nature.Data.Dtos.AnimalDtos;
using Nature.Data.Entities;
using Nature.Domain.Services.Interfaces;

namespace Nature.API.Controllers
{
    [Route("api/[controller]")]
    public class AnimalController : ControllerBase
    {
        private readonly IAnimalService _animalService;

        public AnimalController(IAnimalService animalService)
        {
            _animalService = animalService;
        }

        [HttpGet("get-all")]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken = default)
        {
            var animals = await _animalService.GetAllAsync(cancellationToken);
            return Ok(animals);
        }

        [HttpGet]
        public async Task<IActionResult> GetById(Guid id, CancellationToken cancellationToken = default)
        {
            var animal = await _animalService.GetByIdAsync(id, cancellationToken);

            if (animal == null) return NotFound();

            return Ok(animal);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateAnimalDto animal, CancellationToken cancellationToken)
        {
            var newAnimal = new Animal
            {
                Name = animal.Name,
                Description = animal.Description,
                Habitat = animal.Habitat,
                ImageFilePath = animal.ImageFilePath,
                SoundFilePath = animal.SoundFilePath,
                AnimalType = animal.AnimalType,
                Movement = animal.Movement,
            };

            var id = await _animalService.CreateAsync(newAnimal, cancellationToken);
            return CreatedAtAction(nameof(GetById), new { id }, newAnimal);
        }

        [HttpPut("put")]
        public async Task<IActionResult> Update([FromBody] UpdateAnimalDto updateAnimal, CancellationToken cancellationToken)
        {
            if (updateAnimal == null || updateAnimal.Id == Guid.Empty)
                return BadRequest("Invalid data.");

            var existingAnimal = await _animalService.GetByIdAsync(updateAnimal.Id, cancellationToken);

            if (existingAnimal == null)
                return NotFound();

            var updatedAnimal = await _animalService.UpdateAsync(new Animal
            {
                Id = updateAnimal.Id,
                Name = updateAnimal.Name,
                Description = updateAnimal.Description,
                Habitat = updateAnimal.Habitat,
                ImageFilePath = updateAnimal.ImageFilePath,
                SoundFilePath = updateAnimal.SoundFilePath,
                AnimalType = updateAnimal.AnimalType,
                Movement = updateAnimal.Movement,
            }, cancellationToken);

            return Ok(updatedAnimal);
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Guid id, CancellationToken cancellationToken)
        {
            await _animalService.DeleteAsync(id, cancellationToken);
            return NoContent();
        }
    }
}
