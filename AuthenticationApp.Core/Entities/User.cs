using Microsoft.AspNetCore.Identity;

namespace AuthenticationApp.Core.Entities
{
    public class User : IdentityUser
    {
        public required string FullName { get; set; }

        public string? ProfileImageURL { get; set; }
    }
}
