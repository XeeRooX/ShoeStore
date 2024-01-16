using AutoMapper;
using ShoeStore.Dtos.ShoesType;
using ShoeStore.Models;

namespace ShoeStore.MappingConfigurations
{
    public class ShoesTypeProfile : Profile
    {
        public ShoesTypeProfile() 
        {
            CreateMap<ShoeType, GetShoesTypeOutDto>();
            CreateMap<AddShoesTypeDto, ShoeType>();
            CreateMap<EditShoesTypeDto, ShoeType>();
        }
    }
}
