using MediatR;
using ShoeStore.Dtos.Shoe;

namespace ShoeStore.Queries
{
    public record class GetAllShoesQuery : IRequest<IEnumerable<GetShoeFullDto>>;
}
