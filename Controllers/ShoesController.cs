using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using ShoeStore.Commands;
using ShoeStore.Dtos.Shoe;
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

        [HttpPost("get")]
        public async Task<IActionResult> Get(GetShoesDto input)
        {
            var result = await _mediator.Send(new GetShoesQuery(input));
            return Ok(result);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(AddShoesDto input)
        {
            var result = await _mediator.Send(new AddShoesCommand(input));
            return Ok(result);
        }

        [HttpPut("edit")]
        public async Task<IActionResult> Edit(EditShoesDto input)
        {
            var result = await _mediator.Send(new EditShoesCommand(input));
            return Ok(result);
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(GetShoesDto input)
        {
            var result = await _mediator.Send(new RemoveShoesCommand(input));
            return Ok(result);
        }
    }
}
