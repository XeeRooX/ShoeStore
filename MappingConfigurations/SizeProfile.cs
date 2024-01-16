using AutoMapper;
using ShoeStore.Dtos.Size;
using ShoeStore.Models;

namespace ShoeStore.MappingConfigurations
{
    public class SizeProfile : Profile
    {
        public SizeProfile()
        {
            CreateMap<Size, GetSizeOutDto>();
            CreateMap<AddSizeDto, Size>();
            CreateMap<EditSizeDto, Size>();
        }
    }
}
