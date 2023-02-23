namespace JwtAuthForBooks.Models;

/// <summary>
/// Generate Token Response
/// </summary>
public class GenerateTokenResponse
{
    /// <summary>Gets or sets the token.</summary>
    /// <value>The token.</value>
    public string Token { get; set; }

    /// <summary>Gets or sets the token expire date.</summary>
    /// <value>The token expire date.</value>
    public DateTime TokenExpireDate { get; set; }
}
