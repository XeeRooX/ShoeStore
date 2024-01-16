using AutoMapper;
using MediatR;
using ShoeStore.Commands.Season;
using ShoeStore.Data.Repositories;
using ShoeStore.Dtos.Season;
using ShoeStore.Models;

namespace ShoeStore.Handlers.Season
{
    public class AddSeasonHandler : IRequestHandler<AddSeasonCommand, GetSeasonOutDto>
    {
        private readonly IMapper _mapper;
        private readonly ISeasonRepository _seasonRepository;
        public AddSeasonHandler(IMapper mapper, ISeasonRepository seasonRepository)
        {
            _mapper = mapper;
            _seasonRepository = seasonRepository;
        }
        public async Task<GetSeasonOutDto> Handle(AddSeasonCommand request, CancellationToken cancellationToken)
        {

            var addResult = await _seasonRepository.AddAsync(_mapper.Map<Models.Season>(request.Season));
            var result = _mapper.Map<GetSeasonOutDto>(addResult);
            return result;
        }
    }
}
