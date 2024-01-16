using MediatR;
using ShoeStore.Dtos.Brand;

namespace ShoeStore.Commands.Brand
{
    public record class AddBrandCommand(AddBrandDto Brand) : IRequest<GetBrandOutDto>;
}
