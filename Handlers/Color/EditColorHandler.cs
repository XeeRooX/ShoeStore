using AutoMapper;
using MediatR;
using ShoeStore.Commands.Color;
using ShoeStore.Data.Repositories;
using ShoeStore.Dtos.Color;
using ShoeStore.Models;

namespace ShoeStore.Handlers.Color
{
    public class EditColorHandler : IRequestHandler<EditColorCommand, GetColorOutDto>
    {
        private readonly IMapper _mapper;
        private readonly IColorRepository _colorRepository;
        public EditColorHandler(IMapper mapper, IColorRepository colorRepository)
        {
            _mapper = mapper;
            _colorRepository = colorRepository;
        }
        public async Task<GetColorOutDto> Handle(EditColorCommand request, CancellationToken cancellationToken)
        {
            var editResult = await _colorRepository.UpdateAsync(_mapper.Map<Models.Color>(request.Color));
            var result = _mapper.Map<GetColorOutDto>(editResult);
            return result;
        }
    }
}
