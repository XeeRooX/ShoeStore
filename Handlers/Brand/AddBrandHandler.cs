using AutoMapper;
using MediatR;
using ShoeStore.Commands.Brand;
using ShoeStore.Data.Repositories;
using ShoeStore.Dtos.Brand;
using ShoeStore.Models;

namespace ShoeStore.Handlers.Brand
{
    public class AddBrandHandler : IRequestHandler<AddBrandCommand, GetBrandOutDto>
    {
        private readonly IMapper _mapper;
        private readonly IBrandRepository _brandRepository;
        public AddBrandHandler(IMapper mapper, IBrandRepository brandRepository)
        {
            _mapper = mapper;
            _brandRepository = brandRepository;
        }
        public async Task<GetBrandOutDto> Handle(AddBrandCommand request, CancellationToken cancellationToken)
        {

            var addResult = await _brandRepository.AddAsync(_mapper.Map<Models.Brand>(request.Brand));
            var result = _mapper.Map<GetBrandOutDto>(addResult);
            return result;
        }
    }
}
