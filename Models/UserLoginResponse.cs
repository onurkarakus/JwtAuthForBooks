namespace JwtAuthForBooks.Models;

/// <summary>
/// User Login Response
/// </summary>
public class UserLoginResponse
{
    /// <summary>Gets or sets a value indicating whether [authenticate result].</summary>
    /// <value>
    ///   <c>true</c> if [authenticate result]; otherwise, <c>false</c>.</value>
    public bool AuthenticateResult { get; set; }

    /// <summary>Gets or sets the authentication token.</summary>
    /// <value>The authentication token.</value>
    public string AuthToken { get; set; }

    /// <summary>Gets or sets the access token expire date.</summary>
    /// <value>The access token expire date.</value>
    public DateTime AccessTokenExpireDate { get; set; }
}
