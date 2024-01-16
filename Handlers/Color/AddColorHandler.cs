using AutoMapper;
using MediatR;
using ShoeStore.Commands.Color;
using ShoeStore.Data.Repositories;
using ShoeStore.Dtos.Color;
using ShoeStore.Models;

namespace ShoeStore.Handlers.Color
{
    public class AddColorHandler : IRequestHandler<AddColorCommand, GetColorOutDto>
    {
        private readonly IMapper _mapper;
        private readonly IColorRepository _colorRepository;
        public AddColorHandler(IMapper mapper, IColorRepository colorRepository)
        {
            _mapper = mapper;
            _colorRepository = colorRepository;
        }
        public async Task<GetColorOutDto> Handle(AddColorCommand request, CancellationToken cancellationToken)
        {

            var addResult = await _colorRepository.AddAsync(_mapper.Map<Models.Color>(request.Color));
            var result = _mapper.Map<GetColorOutDto>(addResult);
            return result;
        }
    }
}
