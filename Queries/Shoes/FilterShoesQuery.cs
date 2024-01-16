using MediatR;
using ShoeStore.Dtos.Shoe;

namespace ShoeStore.Queries.Shoes
{
    public record class FilterShoesQuery(FilterShoesDto shoes) : IRequest<IEnumerable<GetShoesFullDto>>;
}
