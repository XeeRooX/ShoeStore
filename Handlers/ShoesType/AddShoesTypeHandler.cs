using AutoMapper;
using MediatR;
using ShoeStore.Commands.ShoesType;
using ShoeStore.Data.Repositories;
using ShoeStore.Dtos.ShoesType;
using ShoeStore.Models;

namespace ShoeStore.Handlers.ShoesType
{
    public class AddShoesTypeHandler : IRequestHandler<AddShoesTypeCommand, GetShoesTypeOutDto>
    {
        private readonly IMapper _mapper;
        private readonly IShoeTypeRepository _shoeTypeRepository;
        public AddShoesTypeHandler(IMapper mapper, IShoeTypeRepository shoeTypeRepository)
        {
            _mapper = mapper;
            _shoeTypeRepository = shoeTypeRepository;
        }
        public async Task<GetShoesTypeOutDto> Handle(AddShoesTypeCommand request, CancellationToken cancellationToken)
        {

            var addResult = await _shoeTypeRepository.AddAsync(_mapper.Map<Models.ShoeType>(request.ShoesType));
            var result = _mapper.Map<GetShoesTypeOutDto>(addResult);
            return result;
        }
    }
}
