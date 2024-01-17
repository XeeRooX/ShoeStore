using AutoMapper;
using MediatR;
using ShoeStore.Commands.CollectionType;
using ShoeStore.Data.Repositories;
using ShoeStore.Dtos.CollectionType;

namespace ShoeStore.Handlers.CollectionType
{
    public class RemoveCollectionTypeHandler : IRequestHandler<RemoveCollectionTypeCommand, GetCollectionTypeOutDto>
    {
        private ICollectionTypeRepository _collectionTypeRepository;
        private IMapper _mapper;

        public RemoveCollectionTypeHandler(ICollectionTypeRepository collectionTypeRepository, IMapper mapper)
        {
            _collectionTypeRepository = collectionTypeRepository;
            _mapper = mapper;
        }
        public async Task<GetCollectionTypeOutDto> Handle(RemoveCollectionTypeCommand request, CancellationToken cancellationToken)
        {
            var deleteResult = await _collectionTypeRepository.DeleteAsync(request.CollectionType.Id);
            var result = _mapper.Map<GetCollectionTypeOutDto>(deleteResult);
            return result;
        }
    }
}
