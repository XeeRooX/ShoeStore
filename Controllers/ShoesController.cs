using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using ShoeStore.Commands.Shoes;
using ShoeStore.Dtos.Shoe;
using ShoeStore.Queries.Shoes;
using Swashbuckle.AspNetCore.Annotations;

namespace ShoeStore.Controllers
{
    [SwaggerTag("Эндпоинты для ведения информации об обуви")]
    public class ShoesController : ApiBaseController
    {
        private readonly IMediator _mediator;
        public ShoesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [SwaggerOperation(Summary = "Получить всю обувь")]
        [HttpGet("all")]
        public async Task<IActionResult> All()
        {
            var result = await _mediator.Send(new GetAllShoesQuery());
            return Ok(result);
        }

        [SwaggerOperation(Summary = "Получить по id")]
        [HttpPost("get")]
        public async Task<IActionResult> Get(GetShoesDto input)
        {
            var result = await _mediator.Send(new GetShoesQuery(input));
            return Ok(result);
        }

        [SwaggerOperation(Summary = "Получить с использованием фильтров")]
        [HttpPost("filter")]
        public async Task<IActionResult> Filter(FilterShoesDto input)
        {
            var result = await _mediator.Send(new FilterShoesQuery(input));
            return Ok(result);
        }

        [SwaggerOperation(Summary = "Добавить новую")]
        [HttpPost("add")]
        public async Task<IActionResult> Add(AddShoesDto input)
        {
            var result = await _mediator.Send(new AddShoesCommand(input));
            return Ok(result);
        }

        [SwaggerOperation(Summary = "Изменить информацию об обуви")]
        [HttpPut("edit")]
        public async Task<IActionResult> Edit(EditShoesDto input)
        {
            var result = await _mediator.Send(new EditShoesCommand(input));
            return Ok(result);
        }

        [SwaggerOperation(Summary = "Удалить информацию об обуви")]
        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(GetShoesDto input)
        {
            var result = await _mediator.Send(new RemoveShoesCommand(input));
            return Ok(result);
        }
    }
}
