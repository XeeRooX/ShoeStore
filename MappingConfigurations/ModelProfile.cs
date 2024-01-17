using AutoMapper;
using ShoeStore.Dtos.Model;
using ShoeStore.Models;

namespace ShoeStore.MappingConfigurations
{
    public class ModelProfile : Profile
    {
        public ModelProfile()
        {
            CreateMap<Model, GetModelOutDto>().
                ForMember(dest => dest.Brand, opts => opts.MapFrom(src => src.Brand.Name));
            CreateMap<AddModelDto, Model>();
            CreateMap<EditModelDto, Model>();
        }
    }
}
