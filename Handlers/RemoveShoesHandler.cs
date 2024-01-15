using AutoMapper;
using MediatR;
using ShoeStore.Commands;
using ShoeStore.Data.Repositories;
using ShoeStore.Dtos.Shoe;

namespace ShoeStore.Handlers
{
    public class RemoveShoesHandler : IRequestHandler<RemoveShoesCommand, GetShoesFullDto>
    {
        private readonly IShoeRepository _shoeRepository;
        private readonly IMapper _mapper;

        public RemoveShoesHandler(IShoeRepository shoeRepository, IMapper mapper)
        {
            _mapper = mapper;
            _shoeRepository = shoeRepository;
        }
        public async Task<GetShoesFullDto> Handle(RemoveShoesCommand request, CancellationToken cancellationToken)
        {
            var deleteResult = await _shoeRepository.DeleteIncludedAsync(request.shoes.Id);
            var result = _mapper.Map<GetShoesFullDto>(deleteResult);

            return result;
        }
    }
}
