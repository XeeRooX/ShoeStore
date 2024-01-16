using MediatR;
using Microsoft.AspNetCore.Mvc;
using ShoeStore.Commands.Color;
using ShoeStore.Dtos.Color;
using ShoeStore.Queries.Colors;

namespace ShoeStore.Controllers
{
    public class ColorController : ApiBaseController
    {
        private readonly IMediator _mediator;
        public ColorController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all")]
        public async Task<IActionResult> All()
        {
            var result = await _mediator.Send(new GetAllColorsQuery());
            return Ok(result);
        }

        [HttpPost("get")]
        public async Task<IActionResult> Get(GetColorInDto input)
        {
            var result = await _mediator.Send(new GetColorQuery(input));
            return Ok(result);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(AddColorDto input)
        {
            var result = await _mediator.Send(new AddColorCommand(input));
            return Ok(result);
        }

        [HttpPut("edit")]
        public async Task<IActionResult> Edit(EditColorDto input)
        {
            var result = await _mediator.Send(new EditColorCommand(input));
            return Ok(result);
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(GetColorInDto input)
        {
            var result = await _mediator.Send(new RemoveColorCommand(input));
            return Ok(result);
        }
    }
}
