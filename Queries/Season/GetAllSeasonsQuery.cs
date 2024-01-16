using MediatR;
using ShoeStore.Dtos.Season;

namespace ShoeStore.Queries.Season
{
    public record class GetAllSeasonsQuery() : IRequest<IEnumerable<GetSeasonOutDto>>;
}
