using AutoMapper;
using MediatR;
using ShoeStore.Data.Repositories;
using ShoeStore.Dtos.Brand;
using ShoeStore.Queries.Brand;

namespace ShoeStore.Handlers.Brand
{
    public class GetBrandHandler : IRequestHandler<GetBrandQuery, GetBrandOutDto>
    {
        private IBrandRepository _brandRepository;
        private IMapper _mapper;

        public GetBrandHandler(IBrandRepository brandRepository, IMapper mapper) 
        {
            _brandRepository = brandRepository;
            _mapper = mapper;
        }
        public async Task<GetBrandOutDto> Handle(GetBrandQuery request, CancellationToken cancellationToken)
        {
            var getResult = await _brandRepository.GetAsync(request.Brand.Id);
            var result = _mapper.Map<GetBrandOutDto>(getResult);
            return result;
        }
    }
}
