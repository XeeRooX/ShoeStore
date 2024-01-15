using AutoMapper;
using ShoeStore.Data.Repositories;
using ShoeStore.Dtos.Shoe;
using ShoeStore.Models;

namespace ShoeStore.MappingConfigurations
{
    public class ShoeProfile : Profile
    {
        public ShoeProfile()
        {
            CreateMap<Shoe, GetShoesFullDto>().
                ForMember(dest => dest.Model, opts => opts.MapFrom(src => src.Model.Name)).
                ForMember(dest => dest.Brand, opts => opts.MapFrom(src => src.Model.Brand.Name)).
                ForMember(dest => dest.BrandId, opts => opts.MapFrom(src => src.Model.BrandId)).
                ForMember(dest => dest.CollectionType, opts => opts.MapFrom(src => src.CollectionType.Name)).
                ForMember(dest => dest.Color, opts => opts.MapFrom(src => src.Color.Name)).
                ForMember(dest => dest.Season, opts => opts.MapFrom(src => src.Season.Name)).
                ForMember(dest => dest.ShoeType, opts => opts.MapFrom(src => src.ShoeType.Name)).
                ForMember(dest => dest.Size, opts => opts.MapFrom(src => src.Size.Number));

            CreateMap<AddShoesDto, Shoe>().
                AfterMap<SetModelInAddMapAction>();

            CreateMap<EditShoesDto, Shoe>().
                AfterMap<SetModelInEditMapAction>();
        }
    }

    class SetModelInEditMapAction : IMappingAction<EditShoesDto, Shoe>
    {
        private readonly IModelRepository _modelRepository;
        public SetModelInEditMapAction(IModelRepository modelRepository)
        {
            _modelRepository = modelRepository;
        }
        public void Process(EditShoesDto source, Shoe destination, ResolutionContext context)
        {
            var model = _modelRepository.Get(source.ModelId);
            destination.Model = model;
        }

    }
    class SetModelInAddMapAction : IMappingAction<AddShoesDto, Shoe>
    {
        private readonly IModelRepository _modelRepository;
        public SetModelInAddMapAction(IModelRepository modelRepository)
        {
            _modelRepository = modelRepository;
        }
        public void Process(AddShoesDto source, Shoe destination, ResolutionContext context)
        {
            var model = _modelRepository.Get(source.ModelId);
            destination.Model = model;
        }
    }
}
