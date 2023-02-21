﻿using JwtAuthForBooks.Interfaces;
using JwtAuthForBooks.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JwtAuthForBooks.Services;

public class TokenService : ITokenService
{
    readonly IConfiguration configuration;

    public TokenService(IConfiguration configuration)
    {
        this.configuration = configuration;
    }

    public Task<GenerateTokenResponse> GenerateToken(GenerateTokenRequest request)
    {
        SymmetricSecurityKey symmetricSecurityKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(configuration["AppSettings:Secret"]));

        var dateTimeNow = DateTime.UtcNow;

        JwtSecurityToken jwt = new JwtSecurityToken(
                issuer: configuration["AppSettings:ValidIssuer"],
                audience: configuration["AppSettings:ValidAudience"],
                claims: new List<Claim> {
                    new Claim("userName", request.Username)
                },
                notBefore: dateTimeNow,
                expires: dateTimeNow.Add(TimeSpan.FromMinutes(500)),
                signingCredentials: new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256)
            );

        return Task.FromResult(new GenerateTokenResponse
        {
            Token = new JwtSecurityTokenHandler().WriteToken(jwt),
            TokenExpireDate = dateTimeNow.Add(TimeSpan.FromMinutes(500))
        });
    }
}
