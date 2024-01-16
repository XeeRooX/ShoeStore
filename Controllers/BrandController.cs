using MediatR;
using Microsoft.AspNetCore.Mvc;
using ShoeStore.Commands.Brand;
using ShoeStore.Dtos.Brand;
using ShoeStore.Queries.Brand;

namespace ShoeStore.Controllers
{
    public class BrandController : ApiBaseController
    {
        private readonly IMediator _mediator;
        public BrandController(IMediator mediator) 
        {
            _mediator = mediator;
        }

        [HttpGet("all")]
        public async Task<IActionResult> All()
        {
            var result = await _mediator.Send(new GetAllBrandsQuery());
            return Ok(result);
        }

        [HttpPost("get")]
        public async Task<IActionResult> Get(GetBrandInDto input)
        {
            var result = await _mediator.Send(new GetBrandQuery(input));
            return Ok(result);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(AddBrandDto input)
        {
            var result = await _mediator.Send(new AddBrandCommand(input));
            return Ok(result);
        }

        [HttpPut("edit")]
        public async Task<IActionResult> Edit(EditBrandDto input)
        {
            var result = await _mediator.Send(new EditBrandCommand(input));
            return Ok(result);
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(GetBrandInDto input)
        {
            var result = await _mediator.Send(new RemoveBrandCommand(input));
            return Ok(result);
        }
    }
}
