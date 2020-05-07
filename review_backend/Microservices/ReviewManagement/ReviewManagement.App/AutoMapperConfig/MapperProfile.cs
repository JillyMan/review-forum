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
            CreateMap<AddressDto, Domain.Entities.Address>();
            CreateMap<HeaderImageDto, Domain.Entities.HeaderImage>();
            CreateMap<CommandCreatePlace, Domain.Entities.Place>();

            CreateMap<CommandCreateDishRate, Domain.Entities.DishRate>();
            CreateMap<CommandCreatePlaceRate, Domain.Entities.PlaceRate>();

            CreateMap<Commands.Comment.Create.CommandCreateComment, Domain.Entities.Comment>();


            CreateMap<Commands.Category.Add.CommandCreateaCategory, Domain.Entities.Category>();
            CreateMap<Commands.Category.Add.CommandCreateaCategory, Domain.Entities.Category>();
        }
    }
}