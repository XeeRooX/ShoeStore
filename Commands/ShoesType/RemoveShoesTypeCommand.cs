using MediatR;
using ShoeStore.Dtos.ShoesType;

namespace ShoeStore.Commands.ShoesType
{
    public record class RemoveShoesTypeCommand(GetShoesTypeInDto ShoeType) : IRequest<GetShoesTypeOutDto>;
}
