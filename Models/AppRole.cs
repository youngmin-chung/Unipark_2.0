using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace serverapp.Models
{
    public class AppRole : IdentityRole
    {
        public ICollection<AppUserRole> UserRoles { get; set; }
    }
}