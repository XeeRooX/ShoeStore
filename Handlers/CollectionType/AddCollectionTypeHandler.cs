using AutoMapper;
using MediatR;
using ShoeStore.Commands.CollectionType;
using ShoeStore.Data.Repositories;
using ShoeStore.Dtos.CollectionType;
using ShoeStore.Models;

namespace ShoeStore.Handlers.CollectionType
{
    public class AddCollectionTypeHandler : IRequestHandler<AddCollectionTypeCommand, GetCollectionTypeOutDto>
    {
        private readonly IMapper _mapper;
        private readonly ICollectionTypeRepository _collectionTypeRepository;
        public AddCollectionTypeHandler(IMapper mapper, ICollectionTypeRepository collectionTypeRepository)
        {
            _mapper = mapper;
            _collectionTypeRepository = collectionTypeRepository;
        }
        public async Task<GetCollectionTypeOutDto> Handle(AddCollectionTypeCommand request, CancellationToken cancellationToken)
        {

            var addResult = await _collectionTypeRepository.AddAsync(_mapper.Map<Models.CollectionType>(request.CollectionType));
            var result = _mapper.Map<GetCollectionTypeOutDto>(addResult);
            return result;
        }
    }
}
