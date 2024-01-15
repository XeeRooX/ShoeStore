using MediatR;
using ShoeStore.Dtos.Shoe;

namespace ShoeStore.Commands
{
    public record class AddShoesCommand(AddShoesDto shoes) : IRequest<GetShoesFullDto>;
}
