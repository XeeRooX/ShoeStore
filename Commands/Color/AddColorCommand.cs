using MediatR;
using ShoeStore.Dtos.Color;

namespace ShoeStore.Commands.Color
{
    public record class AddColorCommand(AddColorDto Color) : IRequest<GetColorOutDto>;
}
