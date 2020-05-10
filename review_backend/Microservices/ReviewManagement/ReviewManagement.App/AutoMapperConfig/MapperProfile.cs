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
            CreateMap<HeaderImageDto, Domain.Entities.HeaderPlaceImage>();

            CreateMap<CommandCreatePlace, Domain.Entities.Place>();

            CreateMap<CommandCreateDishRate, Domain.Entities.DishRate>();
            CreateMap<CommandCreatePlaceRate, Domain.Entities.PlaceRate>();

            CreateMap<Commands.Comment.Create.CommandCreateComment, Domain.Entities.Comment>();

            CreateMap<Commands.Country.Dto.CityDto, Domain.Entities.City>();
            CreateMap<Commands.Country.Create.CommandCreateCountry, Domain.Entities.Country>();
            CreateMap<Commands.Country.Update.CommandCountryUpdate, Domain.Entities.Country>();

            //CreateMap<Commands.City.Create.CommandCreateCity, >();
            //CreateMap<Commands.City.Update.CommandUpdateCity, >();

            CreateMap<Commands.Category.Create.CommandCreateCategory, Domain.Entities.Category>();
            CreateMap<Commands.Category.Create.CommandCreateCategory, Domain.Entities.Category>();
        }
    }
}