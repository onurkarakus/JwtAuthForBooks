# JwtAuthForBooks

Companion code for my article on JWT authentication in ASP.NET Core Web API (.NET 6).

| Language | Blog | Medium |
|---|---|---|
| 🇹🇷 Türkçe | [.NET Core Web API ve JWT Token](https://onurkarakus.com.tr/blog/net-core-web-api-ve-jwt-token/) | [Medium](https://onnurkarakus.medium.com/net-core-web-api-ve-jwt-token-189ed336d615) |
| 🇬🇧 English | [.NET 6 Web API and JWT Token](https://onurkarakus.com.tr/en/blog/net-6-web-api-and-jwt-token/) | [Medium](https://medium.com/geekculture/net-6-web-api-and-jwt-token-32fcedb4a0c9) |

> **Learning sample.** This repository shows the concepts from the article. It is not production code: the user check and the signing key are hard-coded on purpose to keep the example short.

## What it shows

- Issuing a signed JWT after login (`TokenService`)
- Validating the token with `Microsoft.AspNetCore.Authentication.JwtBearer`
- Protecting an endpoint with `[Authorize]` while another stays public
- Testing the flow from Swagger UI with the Bearer token

## Run

Requires the [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0) (or a newer SDK with roll-forward).

```bash
dotnet run
```

Open Swagger at `http://localhost:5047/swagger`.

1. `POST /api/Auth/LoginUser` with the demo user `onur` / `123456` and copy the returned token.
2. Click **Authorize** in Swagger and paste `Bearer <token>`.
3. `POST /api/Book/GetBookTitles` is public. `POST /api/Book/GetBookInformationById` (body `{ "id": 1 }`) returns `401` without the token and `200` with it.

## In a real application

Keep the signing key in a secret store (user-secrets, Azure Key Vault), check users against a real identity store with hashed passwords, and use short-lived access tokens with refresh tokens. For a fuller example, see [dotnet-oauth2-refresh-token-api](https://github.com/onurkarakus/dotnet-oauth2-refresh-token-api).
