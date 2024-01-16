using AutoMapper;
using MediatR;
using ShoeStore.Data.Repositories;
using ShoeStore.Dtos.Color;
using ShoeStore.Queries.Colors;

namespace ShoeStore.Handlers.Color
{
    public class GetColorHandler : IRequestHandler<GetColorQuery, GetColorOutDto>
    {
        private IColorRepository _colorRepository;
        private IMapper _mapper;

        public GetColorHandler(IColorRepository colorRepository, IMapper mapper) 
        {
            _colorRepository = colorRepository;
            _mapper = mapper;
        }
        public async Task<GetColorOutDto> Handle(GetColorQuery request, CancellationToken cancellationToken)
        {
            var getResult = await _colorRepository.GetAsync(request.color.Id);
            var result = _mapper.Map<GetColorOutDto>(getResult);
            return result;
        }
    }
}
