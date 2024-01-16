using AutoMapper;
using MediatR;
using ShoeStore.Commands.Color;
using ShoeStore.Data.Repositories;
using ShoeStore.Dtos.Color;

namespace ShoeStore.Handlers.Color
{
    public class RemoveColorHandler : IRequestHandler<RemoveColorCommand, GetColorOutDto>
    {
        private IColorRepository _colorRepository;
        private IMapper _mapper;

        public RemoveColorHandler(IColorRepository colorRepository, IMapper mapper)
        {
            _colorRepository = colorRepository;
            _mapper = mapper;
        }
        public async Task<GetColorOutDto> Handle(RemoveColorCommand request, CancellationToken cancellationToken)
        {
            var deleteResult = await _colorRepository.DeleteAsync(request.Color.Id);
            var result = _mapper.Map<GetColorOutDto>(deleteResult);
            return result;
        }
    }
}
