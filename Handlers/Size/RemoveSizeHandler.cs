using AutoMapper;
using MediatR;
using ShoeStore.Commands.Size;
using ShoeStore.Data.Repositories;
using ShoeStore.Dtos.Size;

namespace ShoeStore.Handlers.Size
{
    public class RemoveSizeHandler : IRequestHandler<RemoveSizeCommand, GetSizeOutDto>
    {
        private ISizeRepository _sizeRepository;
        private IMapper _mapper;

        public RemoveSizeHandler(ISizeRepository sizeRepository, IMapper mapper)
        {
            _sizeRepository = sizeRepository;
            _mapper = mapper;
        }
        public async Task<GetSizeOutDto> Handle(RemoveSizeCommand request, CancellationToken cancellationToken)
        {
            var deleteResult = await _sizeRepository.DeleteAsync(request.Size.Id);
            var result = _mapper.Map<GetSizeOutDto>(deleteResult);
            return result;
        }
    }
}
