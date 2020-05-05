using AutoMapper;

namespace ReviewManagement.App.AutoMapperConfig
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Commands.Place.AddPlace.Command, Domain.Entities.Place>();

            CreateMap<Commands.Place.Rate.CommandPlaceRate, Domain.Entities.PlaceRate>();
            CreateMap<Commands.Place.Rate.CommandDishRate, Domain.Entities.DishRate>();

            CreateMap<Commands.Place.AddComment.Command, Domain.Entities.Comment>();
            CreateMap<Commands.Category.Add.Command, Domain.Entities.Category>();
            CreateMap<Commands.Category.Add.Command, Domain.Entities.Category>();
        }
    }
}
