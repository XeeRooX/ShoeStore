using MediatR;
using ShoeStore.Dtos.Model;

namespace ShoeStore.Commands.Model
{
    public record class AddModelCommand(AddModelDto Model) : IRequest<GetModelOutDto>;
}
