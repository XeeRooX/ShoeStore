using MediatR;
using Microsoft.AspNetCore.Mvc;
using ShoeStore.Dtos.CollectionType;
using ShoeStore.Queries.CollectionType;

namespace ShoeStore.Controllers
{
    public class CollectionTypeController : ApiBaseController
    {
        private readonly IMediator _mediator;
        public CollectionTypeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all")]
        public async Task<IActionResult> All()
        {
            var result = await _mediator.Send(new GetAllCollectionTypesQuery());
            return Ok(result);
        }

        [HttpPost("get")]
        public async Task<IActionResult> Get(GetCollectionTypeInDto input)
        {
            var result = await _mediator.Send(new GetCollectionTypeQuery(input));
            return Ok(result);
        }
    }
}
