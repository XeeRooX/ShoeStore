using AutoMapper;
using MediatR;
using ShoeStore.Data.Repositories;
using ShoeStore.Dtos.Model;
using ShoeStore.Queries.Model;

namespace ModelStore.Handlers.Model
{
    public class GetAllModelsHandler : IRequestHandler<GetAllModelsQuery, IEnumerable<GetModelOutDto>>
    {
        private readonly IModelRepository _modelRepository;
        private readonly IMapper _mapper;
        public GetAllModelsHandler(IModelRepository modelRepository, IMapper mapper)
        {
            _modelRepository = modelRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<GetModelOutDto>> Handle(GetAllModelsQuery request, CancellationToken cancellationToken)
        {
            var models = await _modelRepository.GetAllIncludedAsync();
            var result = _mapper.Map<IEnumerable<GetModelOutDto>>(models);
            return result;
        }
    }
}
