using MediatR;
using ShoeStore.Dtos.Size;

namespace ShoeStore.Queries.Size
{
    public record class GetAllSizesQuery() : IRequest<IEnumerable<GetSizeOutDto>>;
}
