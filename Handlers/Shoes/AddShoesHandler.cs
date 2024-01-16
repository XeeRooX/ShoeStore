using AutoMapper;
using MediatR;
using ShoeStore.Commands.Shoes;
using ShoeStore.Data.Repositories;
using ShoeStore.Dtos.Shoe;
using ShoeStore.Models;
//using ShoeStore.Models;


namespace ShoeStore.Handlers.Shoes
{
    public class AddShoesHandler : IRequestHandler<AddShoesCommand, GetShoesFullDto>
    {
        private readonly IMapper _mapper;
        private readonly IShoeRepository _shoeRepository;

        public AddShoesHandler(IMapper mapper, IShoeRepository shoeRepository)
        {
            _mapper = mapper;
            _shoeRepository = shoeRepository;
        }
        public async Task<GetShoesFullDto> Handle(AddShoesCommand request, CancellationToken cancellationToken)
        {
            var shoes = _mapper.Map<Shoe>(request.shoes);

            var resultAddShoes = await _shoeRepository.AddAsync(shoes);
            var includedShoes = await _shoeRepository.GetIncludedAsync(resultAddShoes.Id);

            var result = _mapper.Map<GetShoesFullDto>(includedShoes);
            return result;
        }
    }
}
