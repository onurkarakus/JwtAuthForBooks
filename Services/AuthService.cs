using JwtAuthForBooks.Interfaces;
using JwtAuthForBooks.Models;

namespace JwtAuthForBooks.Services;

/// <summary>
/// Auth Service 
/// </summary>
public class AuthService : IAuthService
{
    readonly ITokenService tokenService;

    /// <summary>Initializes a new instance of the <see cref="AuthService" /> class.</summary>
    /// <param name="tokenService">The token service.</param>
    public AuthService(ITokenService tokenService)
    {
        this.tokenService = tokenService;
    }

    /// <summary>Logins the user asynchronous.</summary>
    /// <param name="request">The request.</param>
    /// <returns>
    ///   <br />
    /// </returns>
    /// <exception cref="System.ArgumentNullException">request</exception>
    public async Task<UserLoginResponse> LoginUserAsync(UserLoginRequest request)
    {
        UserLoginResponse response = new();

        if (string.IsNullOrEmpty(request.Username) || string.IsNullOrEmpty(request.Password))
        {
            throw new ArgumentNullException(nameof(request));
        }

        if (request.Username == "onur" && request.Password == "123456")
        {
            var generatedTokenInformation = await tokenService.GenerateToken(new GenerateTokenRequest { Username = request.Username });

            response.AuthenticateResult = true;
            response.AuthToken = generatedTokenInformation.Token;
            response.AccessTokenExpireDate = generatedTokenInformation.TokenExpireDate;           
        }

        return response;
    }
}
