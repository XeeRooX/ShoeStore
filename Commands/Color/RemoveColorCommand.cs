using MediatR;
using ShoeStore.Dtos.Color;

namespace ShoeStore.Commands.Color
{
    public record class RemoveColorCommand(GetColorInDto Color) : IRequest<GetColorOutDto>;
}
