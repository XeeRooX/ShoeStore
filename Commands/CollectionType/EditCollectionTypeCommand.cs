using MediatR;
using ShoeStore.Dtos.CollectionType;

namespace ShoeStore.Commands.CollectionType
{
    public record class EditCollectionTypeCommand(EditCollectionTypeDto CollectionType) : IRequest<GetCollectionTypeOutDto>;
}
