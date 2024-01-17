using AutoMapper;
using MediatR;
using ShoeStore.Commands.Brand;
using ShoeStore.Data.Repositories;
using ShoeStore.Dtos.Brand;

namespace ShoeStore.Handlers.Brand
{
    public class RemoveBrandHandler : IRequestHandler<RemoveBrandCommand, GetBrandOutDto>
    {
        private IBrandRepository _brandRepository;
        private IMapper _mapper;

        public RemoveBrandHandler(IBrandRepository brandRepository, IMapper mapper)
        {
            _brandRepository = brandRepository;
            _mapper = mapper;
        }
        public async Task<GetBrandOutDto> Handle(RemoveBrandCommand request, CancellationToken cancellationToken)
        {
            var deleteResult = await _brandRepository.DeleteAsync(request.Brand.Id);
            var result = _mapper.Map<GetBrandOutDto>(deleteResult);
            return result;
        }
    }
}
