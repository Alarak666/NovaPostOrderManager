using Core.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.FluentConfiguration.IdentityConfigurations;

public class IdentityUserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<Guid>>
{
    public void Configure(EntityTypeBuilder<IdentityUserRole<Guid>> builder)
    {
        builder.HasData(new List<IdentityUserRole<Guid>>
        {
            new()
            {
                UserId = CoreDefaultValues.ApplicationUserAdminId,
                RoleId = CoreDefaultValues.AdminRoleId
            }
        });
    }
}