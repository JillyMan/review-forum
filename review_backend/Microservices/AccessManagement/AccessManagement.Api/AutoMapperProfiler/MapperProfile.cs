using AutoMapper;

namespace AccessManagement.Api.AutoMapperProfiler
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<App.Models.AuthenticateInfo, Api.Models.AuthenticateInfoModel>();
            CreateMap<App.Models.RegisterInfo, Api.Models.RegisterInfoModel>();

            CreateMap<App.Models.IdentityInfo, Api.Services.PayloadInfo>();

            CreateMap<Domain.Entities.UserInfo, Api.Services.PayloadInfo>();
        }
    }
}