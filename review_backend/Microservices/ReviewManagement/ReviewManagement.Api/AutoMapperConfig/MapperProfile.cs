using AutoMapper;
using ReviewManagement.Api.Models.Update;
using ReviewManagement.Api.Models.Create;
using ReviewManagement.App.Models;
using ReviewManagement.Api.Models;
using ReviewManagement.Api.Models.Create.Dto;

namespace ReviewManagement.Api.AutoMapperConfig
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<DishDto, App.Commands.Place.Create.Dto.DishDto>();
            CreateMap<AddressDto, App.Commands.Place.Create.Dto.AddressDto>();
            CreateMap<HeaderImageDto, App.Commands.Place.Create.Dto.HeaderImageDto>();
            CreateMap<PlaceCreateModel, App.Commands.Place.Create.CommandCreatePlace>();


            CreateMap<DishRateCreateModel, App.Commands.Rate.Create.CommandCreateDishRate>();
            CreateMap<PlaceRateCreateModel, App.Commands.Rate.Create.CommandCreatePlaceRate>();


            CreateMap<CommentCreateModel, App.Commands.Comment.Create.CommandCreateComment>();

            //CreateMap<PlaceUpdateModel, App.Commands.Place.UpdatePlace.Command>();
            //CreateMap<CommentCreateModel, App.Commands.Place.AddComment.CommandCreateComment>();

            CreateMap<CreateCategoryModel, App.Commands.Category.Add.CommandCreateaCategory>();
            CreateMap<UpdateCategoryModel, App.Commands.Category.Update.Command>();


            CreateMap<UserCreateModel, RegisterInfo>();
            CreateMap<AuthTokenResponse, AuthenticateInfo>();
            CreateMap<AuthenticateInfoModel, AuthenticateInfo>();
        }
    }
}
