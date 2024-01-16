using AutoMapper;
using MediatR;
using ShoeStore.Data.Repositories;
using ShoeStore.Dtos.Season;
using ShoeStore.Queries.Season;

namespace ShoeStore.Handlers.Season
{
    public class GetSeasonHandler : IRequestHandler<GetSeasonQuery, GetSeasonOutDto>
    {
        private ISeasonRepository _seasonRepository;
        private IMapper _mapper;

        public GetSeasonHandler(ISeasonRepository seasonRepository, IMapper mapper) 
        {
            _seasonRepository = seasonRepository;
            _mapper = mapper;
        }
        public async Task<GetSeasonOutDto> Handle(GetSeasonQuery request, CancellationToken cancellationToken)
        {
            var getResult = await _seasonRepository.GetAsync(request.Season.Id);
            var result = _mapper.Map<GetSeasonOutDto>(getResult);
            return result;
        }
    }
}
