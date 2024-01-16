using AutoMapper;
using MediatR;
using ShoeStore.Data.Repositories;
using ShoeStore.Dtos.Shoe;
using ShoeStore.Queries.Shoes;

namespace ShoeStore.Handlers.Shoes
{
    public class GetShoesHandler : IRequestHandler<GetShoesQuery, GetShoesFullDto>
    {
        private readonly IShoeRepository _shoeRepository;
        private readonly IMapper _mapper;
        public GetShoesHandler(IShoeRepository shoeRepository, IMapper mapper)
        {
            _mapper = mapper;
            _shoeRepository = shoeRepository;
        }
        public async Task<GetShoesFullDto> Handle(GetShoesQuery request, CancellationToken cancellationToken)
        {
            var includedShoes = (await _shoeRepository.GetIncludedAsync(request.shoes.Id))!;
            var result = _mapper.Map<GetShoesFullDto>(includedShoes);

            return result;
        }
    }
}
