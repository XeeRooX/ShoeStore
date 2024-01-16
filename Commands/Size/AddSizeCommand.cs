using MediatR;
using ShoeStore.Dtos.Size;

namespace ShoeStore.Commands.Size
{
    public record class AddSizeCommand(AddSizeDto Size) : IRequest<GetSizeOutDto>;
}
