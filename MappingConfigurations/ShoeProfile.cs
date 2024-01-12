using AutoMapper;
using ShoeStore.Dtos.Shoe;
using ShoeStore.Models;

namespace ShoeStore.MappingConfigurations
{
    public class ShoeProfile : Profile
    {
        public ShoeProfile()
        {
            CreateMap<Shoe, GetShoeFullDto>().
                ForMember(dest => dest.Model, opts => opts.MapFrom(src => src.Model.Name)).
                ForMember(dest => dest.Brand, opts => opts.MapFrom(src => src.Model.Brand.Name)).
                ForMember(dest => dest.CollectionType, opts => opts.MapFrom(src => src.CollectionType.Name)).
                ForMember(dest => dest.Color, opts => opts.MapFrom(src => src.Color.Name)).
                ForMember(dest => dest.Season, opts => opts.MapFrom(src => src.Season.Name)).
                ForMember(dest => dest.ShoeType, opts => opts.MapFrom(src => src.ShoeType.Name)).
                ForMember(dest => dest.Size, opts => opts.MapFrom(src => src.Size.Number));
        }
    }
}
