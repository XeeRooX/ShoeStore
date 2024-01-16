using AutoMapper;
using ShoeStore.Dtos.Brand;
using ShoeStore.Models;

namespace ShoeStore.MappingConfigurations
{
    public class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<Brand, GetBrandOutDto>();
            CreateMap<AddBrandDto, Brand>();
            CreateMap<EditBrandDto, Brand>();
        }
    }
}
