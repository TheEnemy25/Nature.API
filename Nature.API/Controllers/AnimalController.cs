using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Nature.API.Controllers.Base;
using Nature.Application.Commands.Animal;
using Nature.Application.Queries.Animal;

namespace Nature.API.Controllers
{
    [Route("api/[controller]")]
    public class AnimalController : NatureControllerBase
    {
        public AnimalController(IMediator mediator) : base(mediator) { }

        [HttpGet("get-all")]
        //[AutoValidation]
        public async Task<IActionResult> GetAll([FromQuery] GetAllAnimalsQuery request, CancellationToken cancellationToken)
        {
            var actors = await _mediator.Send(request, cancellationToken);

            return Ok(actors);
        }

        [HttpGet("get-by-id")]
        //[AutoValidation]
        public async Task<IActionResult> GetById([FromQuery] GetAnimalByIdQuery request, CancellationToken cancellationToken)
        {
            var actor = await _mediator.Send(request, cancellationToken);

            if (actor == null)
            {
                return NotFound("Actor not found.");
            }

            return Ok(actor);
        }

        //[AutoValidation]

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] CreateAnimalCommand command, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _mediator.Send(command, cancellationToken);
                return Ok(result);
            }

            catch (ValidationException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("put")]
        //[AutoValidation]
        public async Task<IActionResult> Update([FromBody] UpdateAnimalCommand command, CancellationToken cancellationToken)
        {
            try
            {
                await _mediator.Send(command, cancellationToken);
                return Ok($"Actor with id {command.Id} was successfully updated");
            }
            catch (ValidationException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("delete")]
        //[AutoValidation]
        public async Task<IActionResult> Delete(DeleteAnimalCommand command, CancellationToken cancellationToken)
        {
            try
            {
                await _mediator.Send(command, cancellationToken);
                return Ok($"Actor with id {command.Id} was successfully deleted");
            }
            catch (ValidationException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
