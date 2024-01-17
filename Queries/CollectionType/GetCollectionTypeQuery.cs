using MediatR;
using ShoeStore.Dtos.CollectionType;

namespace ShoeStore.Queries.CollectionType
{
    public record class GetCollectionTypeQuery(GetCollectionTypeInDto CollectionType) : IRequest<GetCollectionTypeOutDto>;
}
