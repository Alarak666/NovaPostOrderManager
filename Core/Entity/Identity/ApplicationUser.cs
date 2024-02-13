using Microsoft.AspNetCore.Identity;

namespace Core.Entity.Identity;

public class ApplicationUser : IdentityUser<Guid>
{
    public ICollection<UserActivity>? Activities { get; set; }
}