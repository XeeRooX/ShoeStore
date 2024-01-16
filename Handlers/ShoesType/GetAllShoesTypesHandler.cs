using AutoMapper;
using MediatR;
using ShoeStore.Data.Repositories;
using ShoeStore.Dtos.ShoesType;
using ShoeStore.Queries.ShoesType;

namespace ShoeStore.Handlers.ShoesType
{
    public class GetAllShoesTypesHandler : IRequestHandler<GetAllShoesTypesQuery, IEnumerable<GetShoesTypeOutDto>>
    {
        private readonly IMapper _mapper;
        private readonly IShoeTypeRepository _shoeTypeRepository;
        public GetAllShoesTypesHandler(IMapper mapper, IShoeTypeRepository shoeTypeRepository)
        {
            _mapper = mapper;
            _shoeTypeRepository = shoeTypeRepository;
        }
        public async Task<IEnumerable<GetShoesTypeOutDto>> Handle(GetAllShoesTypesQuery request, CancellationToken cancellationToken)
        {
            var getAllResult = await _shoeTypeRepository.GetAllAsync();
            var result = _mapper.Map<IEnumerable<GetShoesTypeOutDto>>(getAllResult);
            return result;
        }
    }
}
