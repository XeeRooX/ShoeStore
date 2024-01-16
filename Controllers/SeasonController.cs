using MediatR;
using Microsoft.AspNetCore.Mvc;
using ShoeStore.Dtos.Season;
using ShoeStore.Queries.Season;

namespace ShoeStore.Controllers
{
    public class SeasonController : ApiBaseController
    {
        private readonly IMediator _mediator;
        public SeasonController(IMediator mediator) 
        {
            _mediator = mediator;
        }

        [HttpGet("all")]
        public async Task<IActionResult> All()
        {
            var result = await _mediator.Send(new GetAllSeasonsQuery());
            return Ok(result);
        }

        [HttpPost("get")]
        public async Task<IActionResult> Get(GetSeasonInDto input)
        {
            var result = await _mediator.Send(new GetSeasonQuery(input));
            return Ok(result);
        }
    }
}
