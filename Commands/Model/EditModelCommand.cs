using MediatR;
using ShoeStore.Dtos.Model;

namespace ShoeStore.Commands.Model
{
    public record class EditModelCommand(EditModelDto Model) : IRequest<GetModelOutDto>;
}
