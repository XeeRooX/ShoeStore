using MediatR;
using ShoeStore.Dtos.Color;

namespace ShoeStore.Commands.Color
{
    public record class EditColorCommand(EditColorDto Color) : IRequest<GetColorOutDto>;
}
