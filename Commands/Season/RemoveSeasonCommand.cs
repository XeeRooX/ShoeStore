using MediatR;
using ShoeStore.Dtos.Season;

namespace ShoeStore.Commands.Season
{
    public record class RemoveSeasonCommand(GetSeasonInDto Season) : IRequest<GetSeasonOutDto>;
}
