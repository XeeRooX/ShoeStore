using MediatR;
using ShoeStore.Dtos.Brand;

namespace ShoeStore.Commands.Brand
{
    public record class EditBrandCommand(EditBrandDto Brand) : IRequest<GetBrandOutDto>;
}
