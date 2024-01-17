using AutoMapper;
using MediatR;
using ShoeStore.Commands.Brand;
using ShoeStore.Data.Repositories;
using ShoeStore.Dtos.Brand;
using ShoeStore.Models;

namespace ShoeStore.Handlers.Brand
{
    public class EditBrandHandler : IRequestHandler<EditBrandCommand, GetBrandOutDto>
    {
        private readonly IMapper _mapper;
        private readonly IBrandRepository _brandRepository;
        public EditBrandHandler(IMapper mapper, IBrandRepository brandRepository)
        {
            _mapper = mapper;
            _brandRepository = brandRepository;
        }
        public async Task<GetBrandOutDto> Handle(EditBrandCommand request, CancellationToken cancellationToken)
        {
            var editResult = await _brandRepository.UpdateAsync(_mapper.Map<Models.Brand>(request.Brand));
            var result = _mapper.Map<GetBrandOutDto>(editResult);
            return result;
        }
    }
}
