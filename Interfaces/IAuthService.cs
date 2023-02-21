using JwtAuthForBooks.Models;

namespace JwtAuthForBooks.Interfaces;

public interface IAuthService
{
    public Task<UserLoginResponse> LoginUserAsync(UserLoginRequest request);
}
