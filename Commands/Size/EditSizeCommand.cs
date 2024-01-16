using MediatR;
using ShoeStore.Dtos.Size;

namespace ShoeStore.Commands.Size
{
    public record class EditSizeCommand(EditSizeDto Size) : IRequest<GetSizeOutDto>;
}
