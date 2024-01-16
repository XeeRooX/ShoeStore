using MediatR;
using ShoeStore.Dtos.Shoe;

namespace ShoeStore.Queries.Shoes
{
    public record class GetAllShoesQuery : IRequest<IEnumerable<GetShoesFullDto>>;
}
