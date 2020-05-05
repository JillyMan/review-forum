using AutoMapper;
using ReviewManagement.Api.Models.Update;
using ReviewManagement.Api.Models.Create;
using ReviewManagement.App.Models;
using ReviewManagement.Api.Models;

namespace ReviewManagement.Api.AutoMapperConfig
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<RateCreateModel, App.Commands.Place.AddRate.Command>();

            CreateMap<AddressDto, App.Commands.Place.AddPlace.AddressDto>();
            CreateMap<PlaceCreateModel, App.Commands.Place.AddPlace.Command>();

            CreateMap<PlaceUpdateModel, App.Commands.Place.UpdatePlace.Command>();
            CreateMap<CommentCreateModel, App.Commands.Place.AddComment.Command>();

            CreateMap<CreateCategoryModel, App.Commands.Category.Add.Command>();
            CreateMap<UpdateCategoryModel, App.Commands.Category.Update.Command>();


            CreateMap<AuthenticateInfoModel, AuthenticateInfo>();
            CreateMap<UserCreateModel, RegisterInfo>();

            CreateMap<AuthTokenResponse, AuthenticateInfo>();
        }
    }
}
