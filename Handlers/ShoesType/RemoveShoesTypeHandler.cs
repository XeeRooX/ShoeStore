using AutoMapper;
using MediatR;
using ShoeStore.Commands.ShoesType;
using ShoeStore.Data.EFCore;
using ShoeStore.Data.Repositories;
using ShoeStore.Dtos.ShoesType;

namespace ShoeStore.Handlers.ShoesType
{
    public class RemoveShoesTypeHandler : IRequestHandler<RemoveShoesTypeCommand, GetShoesTypeOutDto>
    {
        private IShoeTypeRepository _shoeTypeRepository;
        private IMapper _mapper;

        public RemoveShoesTypeHandler(IShoeTypeRepository shoeTypeRepository, IMapper mapper)
        {
            _shoeTypeRepository = shoeTypeRepository;
            _mapper = mapper;
        }
        public async Task<GetShoesTypeOutDto> Handle(RemoveShoesTypeCommand request, CancellationToken cancellationToken)
        {
            var deleteResult = await _shoeTypeRepository.DeleteAsync(request.ShoeType.Id);
            var result = _mapper.Map<GetShoesTypeOutDto>(deleteResult);
            return result;
        }
    }
}
