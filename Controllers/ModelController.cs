using MediatR;
using Microsoft.AspNetCore.Mvc;
using ShoeStore.Commands.Model;
using ShoeStore.Dtos.Model;
using ShoeStore.Queries.Model;

namespace ShoeStore.Controllers
{
    public class ModelController : ApiBaseController
    {
        private readonly IMediator _mediator;
        public ModelController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all")]
        public async Task<IActionResult> All()
        {
            var result = await _mediator.Send(new GetAllModelsQuery());
            return Ok(result);
        }

        [HttpPost("get")]
        public async Task<IActionResult> Get(GetModelInDto input)
        {
            var result = await _mediator.Send(new GetModelQuery(input));
            return Ok(result);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(AddModelDto input)
        {
            var result = await _mediator.Send(new AddModelCommand(input));
            return Ok(result);
        }

        [HttpPut("edit")]
        public async Task<IActionResult> Edit(EditModelDto input)
        {
            var result = await _mediator.Send(new EditModelCommand(input));
            return Ok(result);
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(GetModelInDto input)
        {
            var result = await _mediator.Send(new RemoveModelCommand(input));
            return Ok(result);
        }
    }
}
