using MediatR;
using ShoeStore.Dtos.Shoe;

namespace ShoeStore.Commands.Shoes
{
    public record class EditShoesCommand(EditShoesDto shoes) : IRequest<GetShoesFullDto>;
}
