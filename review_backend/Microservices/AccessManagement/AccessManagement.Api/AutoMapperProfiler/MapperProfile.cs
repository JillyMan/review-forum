using AccessManagement.App.Models;
using AutoMapper;

namespace AccessManagement.Api.AutoMapperProfiler
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Api.Models.AuthenticateInfoModel, App.Models.AuthenticateInfo>();

            CreateMap<Api.Models.RegisterInfoModel, App.Models.RegisterInfo>();

            CreateMap<Domain.Entities.UserInfo, PayloadInfo>();
        }
    }
}