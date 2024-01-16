using MediatR;
using Microsoft.AspNetCore.Mvc;
using ShoeStore.Dtos.Size;
using ShoeStore.Queries.Size;

namespace ShoeStore.Controllers
{
    public class SizeController : ApiBaseController
    {
        private readonly IMediator _mediator;
        public SizeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all")]
        public async Task<IActionResult> All()
        {
            var result = await _mediator.Send(new GetAllSizesQuery());
            return Ok(result);
        }

        [HttpPost("get")]
        public async Task<IActionResult> Get(GetSizeInDto input)
        {
            var result = await _mediator.Send(new GetSizeQuery(input));
            return Ok(result);
        }
    }
}
