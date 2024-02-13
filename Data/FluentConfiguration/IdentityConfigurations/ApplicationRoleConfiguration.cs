using Core.Constants;
using Core.Entity.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.FluentConfiguration.IdentityConfigurations;

public class ApplicationRoleConfiguration : IEntityTypeConfiguration<ApplicationRole>
{
    public void Configure(EntityTypeBuilder<ApplicationRole> builder)
    {
        builder.ToTable("ApplicationRole");
      
        builder.HasData(new List<ApplicationRole>
        {
            new()
            {
                Id = CoreDefaultValues.AdminRoleId,
                Name = CoreDefaultValues.AdminRoleName,
                NormalizedName = "ADMIN",
                ConcurrencyStamp = CoreDefaultValues.AdminRoleId.ToString()
            }
        });
    }
}