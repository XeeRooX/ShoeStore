using AutoMapper;
using MediatR;
using ShoeStore.Data.Repositories;
using ShoeStore.Dtos.Color;
using ShoeStore.Queries.Colors;

namespace ShoeStore.Handlers.Color
{
    public class GetAllColorsHandler : IRequestHandler<GetAllColorsQuery, IEnumerable<GetColorOutDto>>
    {
        private readonly IMapper _mapper;
        private readonly IColorRepository _colorRepository;
        public GetAllColorsHandler(IMapper mapper, IColorRepository colorRepository)
        {
            _mapper = mapper;
            _colorRepository = colorRepository;
        }
        public async Task<IEnumerable<GetColorOutDto>> Handle(GetAllColorsQuery request, CancellationToken cancellationToken)
        {
            var getAllResult = await _colorRepository.GetAllAsync();
            var result = _mapper.Map<IEnumerable<GetColorOutDto>>(getAllResult);
            return result;
        }
    }
}
