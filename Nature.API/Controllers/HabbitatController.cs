using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nature.API.Controllers.Base;
using Nature.Data.Context;

namespace Nature.API.Controllers
{
    [Route("api/[controller]")]
    public class HabbitatController : NatureControllerBase
    {
        private readonly ApplicationDbContext _context;


        public HabbitatController(IMediator mediator, ApplicationDbContext context) : base(mediator)
        {
            _context = context;
        }

        [HttpGet("get-individuals/{id:guid}")]
        public async Task<IActionResult> GetIndividuals(Guid Id)
        {
            var area = await _context.ReserveAreas.Include(h => h.Habitats).ThenInclude(a => a.Animals).Include(h => h.Habitats).ThenInclude(a => a.Plants).FirstOrDefaultAsync(x => x.Id == Id);

            var animals = area.Habitats.SelectMany(a => a.Animals).DistinctBy(x => x.Name).ToList();
            var plants = area.Habitats.SelectMany(a => a.Plants).DistinctBy(x => x.Name).ToList();

            return Ok(new
            {
                animals = animals,
                plants = plants
            });
        }
    }
}
