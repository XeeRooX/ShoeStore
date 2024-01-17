using MediatR;
using ShoeStore.Dtos.CollectionType;

namespace ShoeStore.Commands.CollectionType
{
    public record class AddCollectionTypeCommand(AddCollectionTypeDto CollectionType) : IRequest<GetCollectionTypeOutDto>;
}
