using CoreWeb.Application.ViewModels;
using CoreWebApi.Domain.Entities.RegisterData;
using AutoMapper;

namespace CoreWeb.Application.AutoMaper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<User, UserViewModel>();
        }
    }
}
