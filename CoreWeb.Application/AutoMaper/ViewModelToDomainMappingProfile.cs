using AutoMapper;
using CoreWeb.Application.ViewModels;
using CoreWebApi.Domain.Entities.RegisterData;

namespace CoreWeb.Application.AutoMaper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<UserViewModel, User>();
        }
    }
}
