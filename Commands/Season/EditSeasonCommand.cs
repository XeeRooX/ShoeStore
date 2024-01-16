using MediatR;
using ShoeStore.Dtos.Season;

namespace ShoeStore.Commands.Season
{
    public record class EditSeasonCommand(EditSeasonDto Season) : IRequest<GetSeasonOutDto>;
}
