using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Nature.API.Controllers.Base
{
    public class NatureControllerBase : ControllerBase
    {
        protected readonly IMediator _mediator;

        public NatureControllerBase(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
