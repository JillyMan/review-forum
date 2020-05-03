using AutoMapper;

namespace ReviewManagement.App.AutoMapperConfig
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Commands.Thing.AddThing.Command, Domain.Entities.Thing>();
            CreateMap<Commands.Thing.AddRate.Command, Domain.Entities.ThingRateInfo>();
            CreateMap<Commands.Thing.AddComment.Command, Domain.Entities.Comment>();

            CreateMap<Commands.Category.Add.Command, Domain.Entities.Category>();
            CreateMap<Commands.Category.Add.Command, Domain.Entities.Category>();
        }
    }
}
