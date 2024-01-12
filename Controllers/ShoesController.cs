using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using ShoeStore.Queries;

namespace ShoeStore.Controllers
{
    public class ShoesController : ApiBaseController
    {
        private readonly IMediator _mediator; 
        public ShoesController(IMediator mediator) 
        {
            _mediator = mediator;
        }

        [HttpGet("all")]
        public async Task<IActionResult> All()
        {
            var result = await _mediator.Send(new GetAllShoesQuery());
            return Ok(result);
        }
    }
}
