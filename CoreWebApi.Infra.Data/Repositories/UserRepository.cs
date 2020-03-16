using CoreWebApi.Domain.Entities.RegisterData;
using CoreWebApi.Domain.Interfaces;
using CoreWebApi.Infra.Data.Context;

namespace CoreWebApi.Infra.Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(CoreWebApiContext context) : base(context)
        {

        }
    }
}
