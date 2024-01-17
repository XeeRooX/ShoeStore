using AutoMapper;
using ShoeStore.Dtos.CollectionType;
using ShoeStore.Models;

namespace ShoeStore.MappingConfigurations
{
    public class CollectionTypeProfile : Profile
    {
        public CollectionTypeProfile()
        {
            CreateMap<CollectionType, GetCollectionTypeOutDto>();
            CreateMap<AddCollectionTypeDto, CollectionType>();
            CreateMap<EditCollectionTypeDto, CollectionType>();
        }
    }
}
