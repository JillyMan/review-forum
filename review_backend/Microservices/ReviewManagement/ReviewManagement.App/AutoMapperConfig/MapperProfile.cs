using AutoMapper;
using ReviewManagement.App.Commands.Place.Create;
using ReviewManagement.App.Commands.Place.Create.Dto;
using ReviewManagement.App.Commands.Rate.Create;

namespace ReviewManagement.App.AutoMapperConfig
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<DishDto, Domain.Entities.Dish>();
            CreateMap<HeaderImageDto, Domain.Entities.HeaderImage>();
            CreateMap<AddressDto, Domain.Entities.Address>();
            CreateMap<CommandCreatePlace, Domain.Entities.Place>();

            CreateMap<CommandCreateDishRate, Domain.Entities.DishRate>();
            CreateMap<CommandCreatePlaceRate, Domain.Entities.PlaceRate>();

            //CreateMap<Commands.Place.AddPlace.Command, Domain.Entities.Place>();
            //CreateMap<Commands.Place.Rate.CommandCreatePlaceRate, Domain.Entities.PlaceRate>();
            //CreateMap<Commands.Place.Rate.CommandCreateDishRate, Domain.Entities.DishRate>();

            CreateMap<Commands.Place.AddComment.CommandCreateComment, Domain.Entities.Comment>();
            CreateMap<Commands.Category.Add.Command, Domain.Entities.Category>();
            CreateMap<Commands.Category.Add.Command, Domain.Entities.Category>();
        }
    }
}
