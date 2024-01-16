using AutoMapper;
using MediatR;
using ShoeStore.Data.Repositories;
using ShoeStore.Dtos.Size;
using ShoeStore.Queries.Size;

namespace ShoeStore.Handlers.Size
{
    public class GetSizeHandler : IRequestHandler<GetSizeQuery, GetSizeOutDto>
    {
        private ISizeRepository _sizeRepository;
        private IMapper _mapper;

        public GetSizeHandler(ISizeRepository sizeRepository, IMapper mapper) 
        {
            _sizeRepository = sizeRepository;
            _mapper = mapper;
        }
        public async Task<GetSizeOutDto> Handle(GetSizeQuery request, CancellationToken cancellationToken)
        {
            var getResult = await _sizeRepository.GetAsync(request.Size.Id);
            var result = _mapper.Map<GetSizeOutDto>(getResult);
            return result;
        }
    }
}
