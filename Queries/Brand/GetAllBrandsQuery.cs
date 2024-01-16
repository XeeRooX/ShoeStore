using MediatR;
using ShoeStore.Dtos.Brand;

namespace ShoeStore.Queries.Brand
{
    public record class GetAllBrandsQuery() : IRequest<IEnumerable<GetBrandOutDto>>;
}
