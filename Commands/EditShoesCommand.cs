using MediatR;
using ShoeStore.Dtos.Shoe;

namespace ShoeStore.Commands
{
    public record class EditShoesCommand(EditShoesDto shoes) : IRequest<GetShoesFullDto>;
}
