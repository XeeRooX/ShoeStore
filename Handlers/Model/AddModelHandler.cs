using AutoMapper;
using MediatR;
using ShoeStore.Commands.Model;
using ShoeStore.Data.Repositories;
using ShoeStore.Dtos.Model;
using ShoeStore.Models;


namespace ModelStore.Handlers.Model
{
    public class AddModelsHandler : IRequestHandler<AddModelCommand, GetModelOutDto>
    {
        private readonly IMapper _mapper;
        private readonly IModelRepository _modelRepository;

        public AddModelsHandler(IMapper mapper, IModelRepository modelRepository)
        {
            _mapper = mapper;
            _modelRepository = modelRepository;
        }
        public async Task<GetModelOutDto> Handle(AddModelCommand request, CancellationToken cancellationToken)
        {
            var Models = _mapper.Map<ShoeStore.Models.Model>(request.Model);

            var resultAddModel = await _modelRepository.AddAsync(Models);
            var includedModel = await _modelRepository.GetIncludedAsync(resultAddModel.Id);

            var result = _mapper.Map<GetModelOutDto>(includedModel);
            return result;
        }
    }
}
