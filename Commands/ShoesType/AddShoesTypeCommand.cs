using MediatR;
using ShoeStore.Dtos.ShoesType;

namespace ShoeStore.Commands.ShoesType
{
    public record class AddShoesTypeCommand(AddShoesTypeDto ShoesType) : IRequest<GetShoesTypeOutDto>;
}
