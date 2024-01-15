using AutoMapper;
using MediatR;
using ShoeStore.Commands;
using ShoeStore.Data.Repositories;
using ShoeStore.Dtos.Shoe;
using ShoeStore.Models;

namespace ShoeStore.Handlers
{
    public class EditShoesHandler : IRequestHandler<EditShoesCommand, GetShoesFullDto>
    {
        private readonly IShoeRepository _shoeRepository;
        private readonly IMapper _mapper;

        public EditShoesHandler(IShoeRepository shoeRepository, IMapper mapper) 
        {
            _shoeRepository = shoeRepository;
            _mapper = mapper;
        }
        public async Task<GetShoesFullDto> Handle(EditShoesCommand request, CancellationToken cancellationToken)
        {
            var shoes = _mapper.Map<Shoe>(request.shoes);
            var shoesResult = await _shoeRepository.UpdateAsync(shoes);
            var includedShoes = await _shoeRepository.GetIncludedAsync(shoesResult.Id);

            var result = _mapper.Map<GetShoesFullDto>(includedShoes);
            return result;
        }
    }
}
