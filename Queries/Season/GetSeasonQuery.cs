using MediatR;
using ShoeStore.Dtos.Season;

namespace ShoeStore.Queries.Season
{
    public record class GetSeasonQuery(GetSeasonInDto Season) : IRequest<GetSeasonOutDto>;
}
