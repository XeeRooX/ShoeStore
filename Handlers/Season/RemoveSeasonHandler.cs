using AutoMapper;
using MediatR;
using ShoeStore.Commands.Season;
using ShoeStore.Data.Repositories;
using ShoeStore.Dtos.Season;

namespace ShoeStore.Handlers.Season
{
    public class RemoveSeasonHandler : IRequestHandler<RemoveSeasonCommand, GetSeasonOutDto>
    {
        private ISeasonRepository _seasonRepository;
        private IMapper _mapper;

        public RemoveSeasonHandler(ISeasonRepository seasonRepository, IMapper mapper)
        {
            _seasonRepository = seasonRepository;
            _mapper = mapper;
        }
        public async Task<GetSeasonOutDto> Handle(RemoveSeasonCommand request, CancellationToken cancellationToken)
        {
            var deleteResult = await _seasonRepository.DeleteAsync(request.Season.Id);
            var result = _mapper.Map<GetSeasonOutDto>(deleteResult);
            return result;
        }
    }
}
