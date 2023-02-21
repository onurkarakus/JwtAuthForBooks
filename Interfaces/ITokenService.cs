using JwtAuthForBooks.Models;

namespace JwtAuthForBooks.Interfaces;

public interface ITokenService
{
    public Task<GenerateTokenResponse> GenerateToken(GenerateTokenRequest request);
}
