using AutoMapper;
using MediatR;
using ShoeStore.Data.Repositories;
using ShoeStore.Dtos.Size;
using ShoeStore.Queries.Size;

namespace ShoeStore.Handlers.Size
{
    public class GetAllSizesHandler : IRequestHandler<GetAllSizesQuery, IEnumerable<GetSizeOutDto>>
    {
        private readonly IMapper _mapper;
        private readonly ISizeRepository _sizeRepository;
        public GetAllSizesHandler(IMapper mapper, ISizeRepository sizeRepository)
        {
            _mapper = mapper;
            _sizeRepository = sizeRepository;
        }
        public async Task<IEnumerable<GetSizeOutDto>> Handle(GetAllSizesQuery request, CancellationToken cancellationToken)
        {
            var getAllResult = await _sizeRepository.GetAllAsync();
            var result = _mapper.Map<IEnumerable<GetSizeOutDto>>(getAllResult);
            return result;
        }
    }
}
