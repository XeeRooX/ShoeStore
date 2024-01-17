using MediatR;
using ShoeStore.Dtos.Model;

namespace ShoeStore.Queries.Model
{
    public record class GetModelQuery(GetModelInDto Model) : IRequest<GetModelOutDto>;
}
