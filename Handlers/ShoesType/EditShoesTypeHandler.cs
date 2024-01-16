using AutoMapper;
using MediatR;
using ShoeStore.Commands.ShoesType;
using ShoeStore.Data.Repositories;
using ShoeStore.Dtos.ShoesType;
using ShoeStore.Models;

namespace ShoeStore.Handlers.ShoesType
{
    public class EditShoesTypeHandler : IRequestHandler<EditShoesTypeCommand, GetShoesTypeOutDto>
    {
        private readonly IMapper _mapper;
        private readonly IShoeTypeRepository _shoeTypeRepository;
        public EditShoesTypeHandler(IMapper mapper, IShoeTypeRepository shoeTypeRepository)
        {
            _mapper = mapper;
            _shoeTypeRepository = shoeTypeRepository;
        }
        public async Task<GetShoesTypeOutDto> Handle(EditShoesTypeCommand request, CancellationToken cancellationToken)
        {
            var editResult = await _shoeTypeRepository.UpdateAsync(_mapper.Map<Models.ShoeType>(request.ShoesType));
            var result = _mapper.Map<GetShoesTypeOutDto>(editResult);
            return result;
        }
    }
}
