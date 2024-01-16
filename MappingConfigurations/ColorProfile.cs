using AutoMapper;
using ShoeStore.Dtos.Color;
using ShoeStore.Models;

namespace ShoeStore.MappingConfigurations
{
    public class ColorProfile : Profile
    {
        public ColorProfile()
        {
            CreateMap<Color, GetColorOutDto>();
            CreateMap<AddColorDto, Color>();
            CreateMap<EditColorDto, Color>();
        }
    }
}
