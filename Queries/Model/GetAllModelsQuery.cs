using MediatR;
using ShoeStore.Dtos.Model;

namespace ShoeStore.Queries.Model
{
    public record class GetAllModelsQuery() : IRequest<IEnumerable<GetModelOutDto>>;
}
