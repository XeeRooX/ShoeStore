using AutoMapper;
using MediatR;
using ShoeStore.Data.EFCore;
using ShoeStore.Data.Repositories;
using ShoeStore.Dtos.ShoesType;
using ShoeStore.Queries.ShoesType;

namespace ShoeStore.Handlers.ShoesType
{
    public class GetShoesTypeHandler : IRequestHandler<GetShoesTypeQuery, GetShoesTypeOutDto>
    {
        private IShoeTypeRepository _shoeTypeRepository;
        private IMapper _mapper;

        public GetShoesTypeHandler(IShoeTypeRepository shoeTypeRepository, IMapper mapper) 
        {
            _shoeTypeRepository = shoeTypeRepository;
            _mapper = mapper;
        }
        public async Task<GetShoesTypeOutDto> Handle(GetShoesTypeQuery request, CancellationToken cancellationToken)
        {
            var getResult = await _shoeTypeRepository.GetAsync(request.ShoeType.Id);
            var result = _mapper.Map<GetShoesTypeOutDto>(getResult);
            return result;
        }
    }
}
