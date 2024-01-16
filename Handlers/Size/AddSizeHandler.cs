using AutoMapper;
using MediatR;
using ShoeStore.Commands.Size;
using ShoeStore.Data.Repositories;
using ShoeStore.Dtos.Size;
using ShoeStore.Models;

namespace ShoeStore.Handlers.Size
{
    public class AddSizeHandler : IRequestHandler<AddSizeCommand, GetSizeOutDto>
    {
        private readonly IMapper _mapper;
        private readonly ISizeRepository _sizeRepository;
        public AddSizeHandler(IMapper mapper, ISizeRepository sizeRepository)
        {
            _mapper = mapper;
            _sizeRepository = sizeRepository;
        }
        public async Task<GetSizeOutDto> Handle(AddSizeCommand request, CancellationToken cancellationToken)
        {

            var addResult = await _sizeRepository.AddAsync(_mapper.Map<Models.Size>(request.Size));
            var result = _mapper.Map<GetSizeOutDto>(addResult);
            return result;
        }
    }
}
