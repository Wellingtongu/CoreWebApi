using CoreWebApi.Domain.Entities.RegisterData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreWebApi.Infra.Data.Mappings
{
    public class UserMappings : IEntityTypeConfiguration<User>
    {
       
      public void Configure(EntityTypeBuilder<User> builder)
     {
          builder.HasKey(c => c.Id);

           builder.Property(c => c.Name)
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(c => c.Admision);

        }
    }
}
