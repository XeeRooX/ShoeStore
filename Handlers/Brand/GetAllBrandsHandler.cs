using AutoMapper;
using MediatR;
using ShoeStore.Data.Repositories;
using ShoeStore.Dtos.Brand;
using ShoeStore.Queries.Brand;

namespace ShoeStore.Handlers.Brand
{
    public class GetAllBrandsHandler : IRequestHandler<GetAllBrandsQuery, IEnumerable<GetBrandOutDto>>
    {
        private readonly IMapper _mapper;
        private readonly IBrandRepository _brandRepository;
        public GetAllBrandsHandler(IMapper mapper, IBrandRepository BrandRepository)
        {
            _mapper = mapper;
            _brandRepository = BrandRepository;
        }
        public async Task<IEnumerable<GetBrandOutDto>> Handle(GetAllBrandsQuery request, CancellationToken cancellationToken)
        {
            var getAllResult = await _brandRepository.GetAllAsync();
            var result = _mapper.Map<IEnumerable<GetBrandOutDto>>(getAllResult);
            return result;
        }
    }
}
