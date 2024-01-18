using MediatR;
using Microsoft.AspNetCore.Mvc;
using ShoeStore.Dtos.Season;
using ShoeStore.Queries.Season;
using Swashbuckle.AspNetCore.Annotations;

namespace ShoeStore.Controllers
{
    [SwaggerTag("Эндпоинты для получения информации о сезоне обуви")]
    public class SeasonController : ApiBaseController
    {
        private readonly IMediator _mediator;
        public SeasonController(IMediator mediator) 
        {
            _mediator = mediator;
        }

        [HttpGet("all")]
        [SwaggerOperation(Summary = "Получить все наименования сезонов")]
        public async Task<IActionResult> All()
        {
            var result = await _mediator.Send(new GetAllSeasonsQuery());
            return Ok(result);
        }

        [SwaggerOperation(Summary = "Получить название сезона по id")]
        [HttpPost("get")]
        public async Task<IActionResult> Get(GetSeasonInDto input)
        {
            var result = await _mediator.Send(new GetSeasonQuery(input));
            return Ok(result);
        }
    }
}
