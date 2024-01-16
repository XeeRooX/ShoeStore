using MediatR;
using ShoeStore.Dtos.Size;

namespace ShoeStore.Queries.Size
{
    public record class GetSizeQuery(GetSizeInDto Size) : IRequest<GetSizeOutDto>;
}
