using MediatR;
using Microsoft.AspNetCore.Mvc;
using ShoeStore.Commands.Brand;
using ShoeStore.Dtos.Brand;
using ShoeStore.Queries.Brand;
using Swashbuckle.AspNetCore.Annotations;

namespace ShoeStore.Controllers
{
    [SwaggerTag("Эндпоинты для ведения информации о брендах обуви")]
    public class BrandController : ApiBaseController
    {
        private readonly IMediator _mediator;
        public BrandController(IMediator mediator) 
        {
            _mediator = mediator;
        }

        [SwaggerOperation(Summary = "Получить все бренды")]
        [HttpGet("all")]
        public async Task<IActionResult> All()
        {
            var result = await _mediator.Send(new GetAllBrandsQuery());
            return Ok(result);
        }

        [SwaggerOperation(Summary = "Получить бренд по id")]
        [HttpPost("get")]
        public async Task<IActionResult> Get(GetBrandInDto input)
        {
            var result = await _mediator.Send(new GetBrandQuery(input));
            return Ok(result);
        }

        [SwaggerOperation(Summary = "Добавить бренд по")]
        [HttpPost("add")]
        public async Task<IActionResult> Add(AddBrandDto input)
        {
            var result = await _mediator.Send(new AddBrandCommand(input));
            return Ok(result);
        }

        [SwaggerOperation(Summary = "Редактировать бренд")]
        [HttpPut("edit")]
        public async Task<IActionResult> Edit(EditBrandDto input)
        {
            var result = await _mediator.Send(new EditBrandCommand(input));
            return Ok(result);
        }

        [SwaggerOperation(Summary = "Удалить бренд")]
        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(GetBrandInDto input)
        {
            var result = await _mediator.Send(new RemoveBrandCommand(input));
            return Ok(result);
        }
    }
}
