using Microsoft.AspNetCore.Identity;

namespace Auth.Api.Microservicio.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
