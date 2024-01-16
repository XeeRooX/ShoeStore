using AutoMapper;
using MediatR;
using ShoeStore.Data.Repositories;
using ShoeStore.Dtos.Season;
using ShoeStore.Queries.Season;

namespace ShoeStore.Handlers.Season
{
    public class GetAllSeasonsHandler : IRequestHandler<GetAllSeasonsQuery, IEnumerable<GetSeasonOutDto>>
    {
        private readonly IMapper _mapper;
        private readonly ISeasonRepository _seasonRepository;
        public GetAllSeasonsHandler(IMapper mapper, ISeasonRepository seasonRepository)
        {
            _mapper = mapper;
            _seasonRepository = seasonRepository;
        }
        public async Task<IEnumerable<GetSeasonOutDto>> Handle(GetAllSeasonsQuery request, CancellationToken cancellationToken)
        {
            var getAllResult = await _seasonRepository.GetAllAsync();
            var result = _mapper.Map<IEnumerable<GetSeasonOutDto>>(getAllResult);
            return result;
        }
    }
}
