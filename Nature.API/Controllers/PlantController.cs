using Microsoft.AspNetCore.Mvc;
using Nature.Data.Dtos.PlantDtos;
using Nature.Data.Entities;
using Nature.Domain.Services.Interfaces;

namespace Nature.API.Controllers
{
    [Route("api/[controller]")]
    public class PlantController : ControllerBase
    {
        private readonly IPlantService _plantService;

        public PlantController(IPlantService plantService)
        {
            _plantService = plantService;
        }

        [HttpGet("get-all")]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken = default)
        {
            var plants = await _plantService.GetAllAsync(cancellationToken);
            return Ok(plants);
        }

        [HttpGet("get-by-id")]
        public async Task<IActionResult> GetById(Guid id, CancellationToken cancellationToken = default)
        {
            var plant = await _plantService.GetByIdAsync(id, cancellationToken);

            if (plant == null)
                return NotFound();

            return Ok(plant);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreatePlantDto plant, CancellationToken cancellationToken = default)
        {
            var newPlant = new Plant
            {
                Name = plant.Name,
                Description = plant.Description,
                Habitat = plant.Habitat,
                ImageFilePath = plant.ImageFilePath,
            };

            var id = await _plantService.CreateAsync(newPlant, cancellationToken);
            return CreatedAtAction(nameof(GetById), new { id }, newPlant);
        }

        [HttpPut("put")]
        public async Task<IActionResult> Update([FromBody] UpdatePlantDto updatePlant, CancellationToken cancellationToken)
        {
            if (updatePlant == null || updatePlant.Id == Guid.Empty)
                return BadRequest("Invalid data.");

            var existingPlant = await _plantService.GetByIdAsync(updatePlant.Id, cancellationToken);

            if (existingPlant == null)
                return NotFound();

            var updatedPlant = await _plantService.UpdateAsync(new Plant
            {
                Id = updatePlant.Id,
                Name = updatePlant.Name,
                Description = updatePlant.Description,
                Habitat = updatePlant.Habitat,
                ImageFilePath = updatePlant.ImageFilePath
            }, cancellationToken);

            return Ok(updatedPlant);
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Guid id, CancellationToken cancellationToken = default)
        {
            await _plantService.DeleteAsync(id, cancellationToken);
            return NoContent();
        }
    }
}
