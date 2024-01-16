using AutoMapper;
using MediatR;
using ShoeStore.Commands.Season;
using ShoeStore.Data.Repositories;
using ShoeStore.Dtos.Season;
using ShoeStore.Models;

namespace ShoeStore.Handlers.Season
{
    public class EditSeasonHandler : IRequestHandler<EditSeasonCommand, GetSeasonOutDto>
    {
        private readonly IMapper _mapper;
        private readonly ISeasonRepository _seasonRepository;
        public EditSeasonHandler(IMapper mapper, ISeasonRepository seasonRepository)
        {
            _mapper = mapper;
            _seasonRepository = seasonRepository;
        }
        public async Task<GetSeasonOutDto> Handle(EditSeasonCommand request, CancellationToken cancellationToken)
        {
            var editResult = await _seasonRepository.UpdateAsync(_mapper.Map<Models.Season>(request.Season));
            var result = _mapper.Map<GetSeasonOutDto>(editResult);
            return result;
        }
    }
}
