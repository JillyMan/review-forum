using AutoMapper;
using ReviewManagement.Api.Models.Update;
using ReviewManagement.Api.Models.Create;

namespace ReviewManagement.Api.AutoMapperConfig
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<ThingCreateModel, App.Commands.Thing.AddThing.Command>();

            CreateMap<ThingUpdateModel, App.Commands.Thing.UpdateThing.Command>();
        }
    }
}
