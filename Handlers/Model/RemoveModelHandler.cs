using AutoMapper;
using MediatR;
using ShoeStore.Commands.Model;
using ShoeStore.Data.Repositories;
using ShoeStore.Dtos.Model;

namespace ModelStore.Handlers.Model
{
    public class RemoveModelsHandler : IRequestHandler<RemoveModelCommand, GetModelOutDto>
    {
        private readonly IModelRepository _modelRepository;
        private readonly IMapper _mapper;

        public RemoveModelsHandler(IModelRepository modelRepository, IMapper mapper)
        {
            _mapper = mapper;
            _modelRepository = modelRepository;
        }
        public async Task<GetModelOutDto> Handle(RemoveModelCommand request, CancellationToken cancellationToken)
        {
            var deleteResult = await _modelRepository.DeleteIncludedAsync(request.Model.Id);
            var result = _mapper.Map<GetModelOutDto>(deleteResult);

            return result;
        }
    }
}
