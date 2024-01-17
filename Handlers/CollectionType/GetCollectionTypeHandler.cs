using AutoMapper;
using MediatR;
using ShoeStore.Data.Repositories;
using ShoeStore.Dtos.CollectionType;
using ShoeStore.Queries.CollectionType;

namespace ShoeStore.Handlers.CollectionType
{
    public class GetCollectionTypeHandler : IRequestHandler<GetCollectionTypeQuery, GetCollectionTypeOutDto>
    {
        private ICollectionTypeRepository _collectionTypeRepository;
        private IMapper _mapper;

        public GetCollectionTypeHandler(ICollectionTypeRepository collectionTypeRepository, IMapper mapper) 
        {
            _collectionTypeRepository = collectionTypeRepository;
            _mapper = mapper;
        }
        public async Task<GetCollectionTypeOutDto> Handle(GetCollectionTypeQuery request, CancellationToken cancellationToken)
        {
            var getResult = await _collectionTypeRepository.GetAsync(request.CollectionType.Id);
            var result = _mapper.Map<GetCollectionTypeOutDto>(getResult);
            return result;
        }
    }
}
