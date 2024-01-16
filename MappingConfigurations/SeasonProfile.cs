using AutoMapper;
using ShoeStore.Dtos.Season;
using ShoeStore.Models;

namespace ShoeStore.MappingConfigurations
{
    public class SeasonProfile : Profile
    {
        public SeasonProfile() 
        {
            CreateMap<Season, GetSeasonOutDto>();
            CreateMap<AddSeasonDto, Season>();
            CreateMap<EditSeasonDto, Season>();
        }
    }
}
