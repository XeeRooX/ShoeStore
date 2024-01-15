using MediatR;
using ShoeStore.Dtos.Shoe;

namespace ShoeStore.Queries
{
    public record class GetShoesQuery(GetShoesDto shoes) : IRequest<GetShoesFullDto>;
}
