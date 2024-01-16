using MediatR;
using ShoeStore.Dtos.Shoe;

namespace ShoeStore.Queries.Shoes
{
    public record class GetShoesQuery(GetShoesDto shoes) : IRequest<GetShoesFullDto>;
}
