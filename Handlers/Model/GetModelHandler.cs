using AutoMapper;
using MediatR;
using ShoeStore.Data.Repositories;
using ShoeStore.Dtos.Model;
using ShoeStore.Queries.Model;

namespace ModelStore.Handlers.Model
{
    public class GetModelsHandler : IRequestHandler<GetModelQuery, GetModelOutDto>
    {
        private readonly IModelRepository _modelRepository;
        private readonly IMapper _mapper;
        public GetModelsHandler(IModelRepository modelRepository, IMapper mapper)
        {
            _mapper = mapper;
            _modelRepository = modelRepository;
        }
        public async Task<GetModelOutDto> Handle(GetModelQuery request, CancellationToken cancellationToken)
        {
            var includedModels = (await _modelRepository.GetIncludedAsync(request.Model.Id))!;
            var result = _mapper.Map<GetModelOutDto>(includedModels);

            return result;
        }
    }
}
