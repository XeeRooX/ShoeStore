using MediatR;
using Microsoft.AspNetCore.Mvc;
using ShoeStore.Dtos.CollectionType;
using ShoeStore.Queries.CollectionType;
using Swashbuckle.AspNetCore.Annotations;

namespace ShoeStore.Controllers
{
    [SwaggerTag("Эндпоинты для получения информации о типах коллекции")]
    public class CollectionTypeController : ApiBaseController
    {
        private readonly IMediator _mediator;
        public CollectionTypeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [SwaggerOperation(Summary = "Получить все типы")]
        [HttpGet("all")]
        public async Task<IActionResult> All()
        {
            var result = await _mediator.Send(new GetAllCollectionTypesQuery());
            return Ok(result);
        }

        [SwaggerOperation(Summary = "Получить тип по id")]
        [HttpPost("get")]
        public async Task<IActionResult> Get(GetCollectionTypeInDto input)
        {
            var result = await _mediator.Send(new GetCollectionTypeQuery(input));
            return Ok(result);
        }
    }
}
