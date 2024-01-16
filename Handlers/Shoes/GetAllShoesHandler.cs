using AutoMapper;
using MediatR;
using ShoeStore.Data.Repositories;
using ShoeStore.Dtos.Shoe;
using ShoeStore.Queries.Shoes;

namespace ShoeStore.Handlers.Shoes
{
    public class GetAllShoesHandler : IRequestHandler<GetAllShoesQuery, IEnumerable<GetShoesFullDto>>
    {
        private readonly IShoeRepository _shoeRepository;
        private readonly IMapper _mapper;
        public GetAllShoesHandler(IShoeRepository shoeRepository, IMapper mapper)
        {
            _shoeRepository = shoeRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<GetShoesFullDto>> Handle(GetAllShoesQuery request, CancellationToken cancellationToken)
        {
            var shoes = await _shoeRepository.GetAllIncludedAsync();
            var result = _mapper.Map<IEnumerable<GetShoesFullDto>>(shoes);
            return result;
        }
    }
}
