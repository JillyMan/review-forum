using AutoMapper;
using ReviewManagement.Api.Models.Update;
using ReviewManagement.Api.Models.Create;

namespace ReviewManagement.Api.AutoMapperConfig
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<RateCreateModel, App.Commands.Thing.AddRate.Command>();
            CreateMap<ThingCreateModel, App.Commands.Thing.AddThing.Command>();
            CreateMap<ThingUpdateModel, App.Commands.Thing.UpdateThing.Command>();
            CreateMap<CommentCreateModel, App.Commands.Thing.AddComment.Command>();

            CreateMap<CreateCategoryModel, App.Commands.Category.Add.Command>();
            CreateMap<UpdateCategoryModel, App.Commands.Category.Update.Command>();
        }
    }
}
