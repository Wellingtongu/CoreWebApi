using CoreWeb.Application.ViewModels;
using System.Linq;

namespace CoreWeb.Application.Interfaces
{
    public interface IUserAppService
    {
        UserViewModel Add(UserViewModel deviceRelay);
        void Update(UserViewModel deviceRelay);
        void Remove(int id);
        UserViewModel GetById(int id);
        IQueryable<UserViewModel> GetAll();
    }
}
