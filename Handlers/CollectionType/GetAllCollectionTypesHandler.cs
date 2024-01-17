using AutoMapper;
using MediatR;
using ShoeStore.Data.Repositories;
using ShoeStore.Dtos.CollectionType;
using ShoeStore.Queries.CollectionType;

namespace ShoeStore.Handlers.CollectionType
{
    public class GetAllCollectionTypesHandler : IRequestHandler<GetAllCollectionTypesQuery, IEnumerable<GetCollectionTypeOutDto>>
    {
        private readonly IMapper _mapper;
        private readonly ICollectionTypeRepository _collectionTypeRepository;
        public GetAllCollectionTypesHandler(IMapper mapper, ICollectionTypeRepository collectionTypeRepository)
        {
            _mapper = mapper;
            _collectionTypeRepository = collectionTypeRepository;
        }
        public async Task<IEnumerable<GetCollectionTypeOutDto>> Handle(GetAllCollectionTypesQuery request, CancellationToken cancellationToken)
        {
            var getAllResult = await _collectionTypeRepository.GetAllAsync();
            var result = _mapper.Map<IEnumerable<GetCollectionTypeOutDto>>(getAllResult);
            return result;
        }
    }
}
