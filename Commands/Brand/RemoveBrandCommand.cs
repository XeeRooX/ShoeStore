using MediatR;
using ShoeStore.Dtos.Brand;

namespace ShoeStore.Commands.Brand
{
    public record class RemoveBrandCommand(GetBrandInDto Brand) : IRequest<GetBrandOutDto>;
}
