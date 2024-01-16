using AutoMapper;
using MediatR;
using ShoeStore.Commands.Size;
using ShoeStore.Data.Repositories;
using ShoeStore.Dtos.Size;
using ShoeStore.Models;

namespace ShoeStore.Handlers.Size
{
    public class EditSizeHandler : IRequestHandler<EditSizeCommand, GetSizeOutDto>
    {
        private readonly IMapper _mapper;
        private readonly ISizeRepository _sizeRepository;
        public EditSizeHandler(IMapper mapper, ISizeRepository sizeRepository)
        {
            _mapper = mapper;
            _sizeRepository = sizeRepository;
        }
        public async Task<GetSizeOutDto> Handle(EditSizeCommand request, CancellationToken cancellationToken)
        {
            var editResult = await _sizeRepository.UpdateAsync(_mapper.Map<Models.Size>(request.Size));
            var result = _mapper.Map<GetSizeOutDto>(editResult);
            return result;
        }
    }
}
