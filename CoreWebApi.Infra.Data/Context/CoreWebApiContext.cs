using CoreWebApi.Domain.Entities.RegisterData;
using Microsoft.EntityFrameworkCore;

namespace CoreWebApi.Infra.Data.Context
{
    public class CoreWebApiContext : DbContext
    {
        public DbSet<User>  Users { get; set; }

        public CoreWebApiContext(DbContextOptions<CoreWebApiContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
    }
}
