using MediatR;
using ShoeStore.Dtos.Brand;

namespace ShoeStore.Queries.Brand
{
    public record class GetBrandQuery(GetBrandInDto Brand) : IRequest<GetBrandOutDto>;
}
