using MediatR;
using ShoeStore.Dtos.Model;

namespace ShoeStore.Commands.Model
{
    public record class RemoveModelCommand(GetModelInDto Model) : IRequest<GetModelOutDto>;
}
