using MediatR;
using ShoeStore.Dtos.ShoesType;

namespace ShoeStore.Commands.ShoesType
{
    public record class EditShoesTypeCommand(EditShoesTypeDto ShoesType) : IRequest<GetShoesTypeOutDto>;
}
