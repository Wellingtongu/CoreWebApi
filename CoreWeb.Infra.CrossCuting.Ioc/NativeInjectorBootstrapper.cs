using AutoMapper;
using AutoMapper.Configuration;
using CoreWeb.Application.Interfaces;
using CoreWeb.Application.Services;
using CoreWebApi.Domain.Interfaces;
using CoreWebApi.Infra.Data.Context;
using CoreWebApi.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace CoreWeb.Infra.CrossCuting.Ioc
{
    public class NativeInjectorBootstrapper
    {
        public static void RegisterServices(IServiceCollection services, Microsoft.Extensions.Configuration.IConfiguration configuration)
        {
            services.AddSingleton(Mapper.Configuration);

            services.AddScoped<IMapper>(sp => new Mapper(sp.GetRequiredService<AutoMapper.IConfigurationProvider>(), sp.GetService));
            services.AddScoped<IUserAppService, UserAppService>();


            //=======================================================
            //Domain
            //=======================================================
            services.AddScoped<IUserRepository, UserRepository>();


            services.AddDbContext<CoreWebApiContext>(opt => opt.UseSqlServer(configuration["ConnectionStrings:DBCoreWebApi"]));

        }
    }
}
