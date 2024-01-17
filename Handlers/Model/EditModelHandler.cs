using AutoMapper;
using MediatR;
using ShoeStore.Commands.Model;
using ShoeStore.Data.Repositories;
using ShoeStore.Dtos.Model;
using ShoeStore.Models;

namespace ModelStore.Handlers.Model
{
    public class EditModelsHandler : IRequestHandler<EditModelCommand, GetModelOutDto>
    {
        private readonly IModelRepository _modelRepository;
        private readonly IMapper _mapper;

        public EditModelsHandler(IModelRepository modelRepository, IMapper mapper)
        {
            _modelRepository = modelRepository;
            _mapper = mapper;
        }
        public async Task<GetModelOutDto> Handle(EditModelCommand request, CancellationToken cancellationToken)
        {
            var model = _mapper.Map<ShoeStore.Models.Model>(request.Model);
            var modelsResult = await _modelRepository.UpdateAsync(model);
            var includedModel = await _modelRepository.GetIncludedAsync(modelsResult.Id);

            var result = _mapper.Map<GetModelOutDto>(includedModel);
            return result;
        }
    }
}
