using MediatR;
using ShoeStore.Dtos.Season;

namespace ShoeStore.Commands.Season
{
    public record class AddSeasonCommand(AddSeasonDto Season) : IRequest<GetSeasonOutDto>;
}
