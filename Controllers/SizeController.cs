using MediatR;
using Microsoft.AspNetCore.Mvc;
using ShoeStore.Dtos.Size;
using ShoeStore.Queries.Size;
using Swashbuckle.AspNetCore.Annotations;

namespace ShoeStore.Controllers
{
    [SwaggerTag("Эндпоинты для получения информации о размере обуви")]
    public class SizeController : ApiBaseController
    {
        private readonly IMediator _mediator;
        public SizeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [SwaggerOperation(Summary = "Получить все размеры")]
        [HttpGet("all")]
        public async Task<IActionResult> All()
        {
            var result = await _mediator.Send(new GetAllSizesQuery());
            return Ok(result);
        }

        [SwaggerOperation(Summary = "Получить размер по id")]
        [HttpPost("get")]
        public async Task<IActionResult> Get(GetSizeInDto input)
        {
            var result = await _mediator.Send(new GetSizeQuery(input));
            return Ok(result);
        }
    }
}
