using AutoMapper;
using ReviewManagement.App.Commands.Place.Create;
using ReviewManagement.App.Commands.Place.Update;
using ReviewManagement.App.Commands.Rate.Create;

namespace ReviewManagement.App.AutoMapperConfig
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            SetupDtos();
            SetupPlaceCommand();
            SetupRateCommands();
            SetupCommantCommands();

            SetupCategoryCommands();
            SetupCountryCommands();

            SetupMapFromDalToApp();
        }

        private void SetupMapFromDalToApp()
        {
            CreateMap<Domain.Entities.Address, Models.Place.AddressModel>();
            CreateMap<Domain.Entities.UserInfo, Models.Place.UserInfoModel>();
            CreateMap<Domain.Entities.Comment, Models.Place.CommentModel>();
            CreateMap<Domain.Entities.HeaderPlaceImage, Models.Place.HeaderPlaceImageModel>();
            CreateMap<Domain.Entities.Dish, Models.Place.DishModel>();
            CreateMap<Domain.Entities.Place, Models.Place.PlaceModel>();
        }

        private void SetupDtos()
        {
            CreateMap<Commands.Place.Dto.ImageDto, Domain.Entities.Image>();
            CreateMap<Commands.Place.Dto.DishDto, Domain.Entities.Dish>();
            CreateMap<Commands.Place.Dto.HeaderImageDto, Domain.Entities.HeaderPlaceImage>();
            CreateMap<Commands.Place.Dto.AddressDto, Domain.Entities.Address>();
            CreateMap<Commands.Country.Dto.CityDto, Domain.Entities.City>();
        }

        private void SetupPlaceCommand()
        {
            CreateMap<CommandCreatePlace, Domain.Entities.Place>();

            CreateMap<CommandUpdatePlace, Domain.Entities.Place>()
                .ForMember(x => x.Dishes, opt => opt.Ignore())
                .ForMember(x => x.HeaderImages, opt => opt.Ignore())
                .ForMember(x => x.Dishes, opt => opt.Ignore());
        }

        private void SetupCommantCommands()
        {
            CreateMap<Commands.Comment.Create.CommandCreateComment, Domain.Entities.Comment>();
        }
        private void SetupRateCommands()
        {
            CreateMap<CommandCreateDishRate, Domain.Entities.DishRate>();
            CreateMap<CommandCreatePlaceRate, Domain.Entities.PlaceRate>();
        }

        private void SetupCategoryCommands()
        {
            CreateMap<Commands.Category.Create.CommandCreateCategory, Domain.Entities.Category>();
            CreateMap<Commands.Category.Create.CommandCreateCategory, Domain.Entities.Category>();
        }

        private void SetupCountryCommands()
        {
            CreateMap<Commands.Country.Create.CommandCreateCountry, Domain.Entities.Country>();
            CreateMap<Commands.Country.Update.CommandCountryUpdate, Domain.Entities.Country>();

            //CreateMap<Commands.City.Create.CommandCreateCity, >();
            //CreateMap<Commands.City.Update.CommandUpdateCity, >();
        }
    }
}