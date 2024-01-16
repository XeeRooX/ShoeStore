using MediatR;
using ShoeStore.Dtos.Shoe;

namespace ShoeStore.Commands.Shoes
{
    public record class RemoveShoesCommand(GetShoesDto shoes) : IRequest<GetShoesFullDto>;
}
