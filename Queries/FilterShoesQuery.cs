using MediatR;
using ShoeStore.Dtos.Shoe;

namespace ShoeStore.Queries
{
    public record class FilterShoesQuery(FilterShoesDto shoes) : IRequest<IEnumerable<GetShoesFullDto>>;
}
