using AutoMapper;
using MediatR;
using ShoeStore.Data.Repositories;
using ShoeStore.Dtos.Shoe;
using ShoeStore.Queries.Shoes;

namespace ShoeStore.Handlers.Shoes
{
    public class FilterShoesHandler : IRequestHandler<FilterShoesQuery, IEnumerable<GetShoesFullDto>>
    {
        private readonly IShoeRepository _shoeRepository;
        private readonly IMapper _mapper;

        public FilterShoesHandler(IShoeRepository shoeRepository, IMapper mapper)
        {
            _mapper = mapper;
            _shoeRepository = shoeRepository;
        }
        public async Task<IEnumerable<GetShoesFullDto>> Handle(FilterShoesQuery request, CancellationToken cancellationToken)
        {
            var filterResult = await _shoeRepository.FilterIncludedAsync(request.shoes);
            var result = _mapper.Map<IEnumerable<GetShoesFullDto>>(filterResult);

            return result;
        }
    }
}
