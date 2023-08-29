using Auth.Api.Microservicio.Models.Dto;

namespace Auth.Api.Microservicio.Service.IService
{
    public interface IAuthService
    {
        Task<string> Register(RegistrationRequestDto RegistrationRequestDto);
        Task<LoginResponseDto> Login(LoginRequestDto loginRequestDto);
        Task<bool> AssignRole(string email,string roleName);

    }
}
