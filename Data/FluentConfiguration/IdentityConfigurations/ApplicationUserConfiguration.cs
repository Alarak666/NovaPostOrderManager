using Core.Constants;
using Core.Entity.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.FluentConfiguration.IdentityConfigurations;

public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        builder.ToTable("ApplicationUser");

        var hasher = new PasswordHasher<ApplicationUser>();
        var admin = new ApplicationUser
        {
            Id = CoreDefaultValues.ApplicationUserAdminId,
            ConcurrencyStamp = CoreDefaultValues.ApplicationUserAdminId.ToString(),
            Email = "tgarat@ukr.net",
            EmailConfirmed = true,
            LockoutEnabled = false,
            AccessFailedCount = 0,
            NormalizedEmail = "TGARAT@UKR.NET",
            NormalizedUserName = "ADMIN",
            UserName = "admin",
            TwoFactorEnabled = false,
            SecurityStamp = CoreDefaultValues.ApplicationUserAdminId.ToString(),
            PhoneNumberConfirmed = false,
        };

        admin.PasswordHash = hasher.HashPassword(admin, "0");

        builder.HasData(admin);
    }
}