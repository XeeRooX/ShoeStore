using MediatR;
using ShoeStore.Dtos.CollectionType;

namespace ShoeStore.Commands.CollectionType
{
    public record class RemoveCollectionTypeCommand(GetCollectionTypeInDto CollectionType) : IRequest<GetCollectionTypeOutDto>;
}
