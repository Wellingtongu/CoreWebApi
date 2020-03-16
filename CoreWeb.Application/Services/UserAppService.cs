using AutoMapper;
using AutoMapper.QueryableExtensions;
using CoreWeb.Application.Interfaces;
using CoreWeb.Application.ViewModels;
using CoreWebApi.Domain.Entities.RegisterData;
using CoreWebApi.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreWeb.Application.Services
{
    public class UserAppService : IUserAppService
    {
        private IMapper mapper;
        private IUserRepository repository;

        public UserAppService(IMapper imapper, IUserRepository irepository)
        {
            mapper = imapper;
            repository = irepository;
        }

        public UserViewModel Add(UserViewModel user)
        {
            var entity = mapper.Map<User>(user);

            repository.Add(entity);
            return mapper.Map<UserViewModel>(user);
        }

        public IQueryable<UserViewModel> GetAll()
        {
            return repository.GetAll().ProjectTo<UserViewModel>();
        }

        public UserViewModel GetById(int id)
        {
            return mapper.Map<UserViewModel>(repository.GetById(id));
        }

        public void Remove(int id)
        {
            repository.Remove(id);
        }

        public void Update(UserViewModel user)
        {
            repository.Update(mapper.Map<User>(user));
        }
    }
}
