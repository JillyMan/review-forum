using AutoMapper;
using ReviewManagement.Api.Models.Update;
using ReviewManagement.Api.Models.Create;
using ReviewManagement.App.Models;
using ReviewManagement.Api.Models;
using ReviewManagement.Api.Models.Dto;
using ReviewManagement.Api.Models.Delete;

namespace ReviewManagement.Api.AutoMapperConfig
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<ImageDto, App.Commands.Place.Dto.ImageDto>();
            CreateMap<DishDto, App.Commands.Place.Dto.DishDto>();
            CreateMap<AddressDto, App.Commands.Place.Dto.AddressDto>();
            CreateMap<HeaderImageDto, App.Commands.Place.Dto.HeaderImageDto>();
            CreateMap<PlaceCreateModel, App.Commands.Place.Create.CommandCreatePlace>();


            CreateMap<DishRateCreateModel, App.Commands.Rate.Create.CommandCreateDishRate>();
            CreateMap<PlaceRateCreateModel, App.Commands.Rate.Create.CommandCreatePlaceRate>();

            CreateMap<CommentCreateModel, App.Commands.Comment.Create.CommandCreateComment>();


            CreateMap<CreateCategoryModel, App.Commands.Category.Create.CommandCreateCategory>();
            CreateMap<UpdateCategoryModel, App.Commands.Category.Update.CommandCategoryUpdate>();

            CreateMap<CountryCreateModel, App.Commands.Country.Create.CommandCreateCountry>();
            CreateMap<CityCreateModel, App.Commands.Country.Dto.CityDto>();
            CreateMap<CountryCreateModel, App.Commands.Country.Update.CommandCountryUpdate>();


            CreateMap<CityCreateModel, App.Commands.City.Create.CommandCreateCity>();
            CreateMap<CityCreateModel, App.Commands.City.Update.CommandUpdateCity>();


            CreateMap<DeleteMultiplyModel, App.Commands.City.Delete.CommandDeleteMultiplyCity>();


            CreateMap<UserCreateModel, RegisterInfo>();
            CreateMap<AuthTokenResponse, AuthenticateInfo>();
            CreateMap<AuthenticateInfoModel, AuthenticateInfo>();
        }
    }
}
