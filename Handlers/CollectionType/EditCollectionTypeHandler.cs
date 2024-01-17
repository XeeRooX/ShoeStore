using AutoMapper;
using MediatR;
using ShoeStore.Commands.CollectionType;
using ShoeStore.Data.Repositories;
using ShoeStore.Dtos.CollectionType;
using ShoeStore.Models;

namespace ShoeStore.Handlers.CollectionType
{
    public class EditCollectionTypeHandler : IRequestHandler<EditCollectionTypeCommand, GetCollectionTypeOutDto>
    {
        private readonly IMapper _mapper;
        private readonly ICollectionTypeRepository _collectionTypeRepository;
        public EditCollectionTypeHandler(IMapper mapper, ICollectionTypeRepository collectionTypeRepository)
        {
            _mapper = mapper;
            _collectionTypeRepository = collectionTypeRepository;
        }
        public async Task<GetCollectionTypeOutDto> Handle(EditCollectionTypeCommand request, CancellationToken cancellationToken)
        {
            var editResult = await _collectionTypeRepository.UpdateAsync(_mapper.Map<Models.CollectionType>(request.CollectionType));
            var result = _mapper.Map<GetCollectionTypeOutDto>(editResult);
            return result;
        }
    }
}
