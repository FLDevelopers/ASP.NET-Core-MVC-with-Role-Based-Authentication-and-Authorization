using Microsoft.AspNetCore.Identity;

namespace UserRoles.Models
{
    public class Users : IdentityUser
    {
        public string FullName { get; set; }
    }
}
