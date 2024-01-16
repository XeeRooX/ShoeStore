using MediatR;
using Microsoft.AspNetCore.Mvc;
using ShoeStore.Commands.ShoesType;
using ShoeStore.Dtos.ShoesType;
using ShoeStore.Queries.ShoesType;

namespace ShoeStore.Controllers
{
    public class ShoesTypeController : ApiBaseController
    {
        private readonly IMediator _mediator;
        public ShoesTypeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all")]
        public async Task<IActionResult> All()
        {
            var result = await _mediator.Send(new GetAllShoesTypesQuery());
            return Ok(result);
        }

        [HttpPost("get")]
        public async Task<IActionResult> Get(GetShoesTypeInDto input)
        {
            var result = await _mediator.Send(new GetShoesTypeQuery(input));
            return Ok(result);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(AddShoesTypeDto input)
        {
            var result = await _mediator.Send(new AddShoesTypeCommand(input));
            return Ok(result);
        }

        [HttpPut("edit")]
        public async Task<IActionResult> Edit(EditShoesTypeDto input)
        {
            var result = await _mediator.Send(new EditShoesTypeCommand(input));
            return Ok(result);
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(GetShoesTypeInDto input)
        {
            var result = await _mediator.Send(new RemoveShoesTypeCommand(input));
            return Ok(result);
        }
    }
}
