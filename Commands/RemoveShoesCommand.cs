using MediatR;
using ShoeStore.Dtos.Shoe;

namespace ShoeStore.Commands
{
    public record class RemoveShoesCommand(GetShoesDto shoes) : IRequest<GetShoesFullDto>;
}
