using MediatR;
using ShoeStore.Dtos.ShoesType;

namespace ShoeStore.Queries.ShoesType
{
    public record class GetAllShoesTypesQuery() : IRequest<IEnumerable<GetShoesTypeOutDto>>;
}
