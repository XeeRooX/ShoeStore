using MediatR;
using ShoeStore.Dtos.Shoe;

namespace ShoeStore.Commands.Shoes
{
    public record class AddShoesCommand(AddShoesDto shoes) : IRequest<GetShoesFullDto>;
}
