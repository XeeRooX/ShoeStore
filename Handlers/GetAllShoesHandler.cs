using AutoMapper;
using MediatR;
using ShoeStore.Data.Repositories;
using ShoeStore.Dtos.Shoe;
using ShoeStore.Queries;

namespace ShoeStore.Handlers
{
    public class GetAllShoesHandler : IRequestHandler<GetAllShoesQuery, IEnumerable<GetShoeFullDto>>
    {
        private readonly IShoeRepository _shoeRepository;
        private readonly IMapper _mapper;
        public GetAllShoesHandler(IShoeRepository shoeRepository, IMapper mapper)
        {
            _shoeRepository = shoeRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<GetShoeFullDto>> Handle(GetAllShoesQuery request, CancellationToken cancellationToken)
        {
            var shoes = await _shoeRepository.GetAllAsync();
            var result = _mapper.Map<IEnumerable<GetShoeFullDto>>(shoes);
            return result;
        }
    }
}
