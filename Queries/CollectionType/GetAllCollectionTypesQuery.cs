using MediatR;
using ShoeStore.Dtos.CollectionType;

namespace ShoeStore.Queries.CollectionType
{
    public record class GetAllCollectionTypesQuery() : IRequest<IEnumerable<GetCollectionTypeOutDto>>;
}
