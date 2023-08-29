using Auth.Api.Microservicio.Models;
using System.Globalization;

namespace Auth.Api.Microservicio.Service
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(ApplicationUser applicationUser);
    }
}
