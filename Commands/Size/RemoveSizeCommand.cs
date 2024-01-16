using MediatR;
using ShoeStore.Dtos.Size;

namespace ShoeStore.Commands.Size
{
    public record class RemoveSizeCommand(GetSizeInDto Size) : IRequest<GetSizeOutDto>;
}
