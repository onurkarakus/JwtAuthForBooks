//UserLoginRequest.cs 

namespace JwtAuthForBooks.Models;

/// <summary>
/// User Login Request
/// </summary>
public class UserLoginRequest
{
    /// <summary>Gets or sets the username.</summary>
    /// <value>The username.</value>
    public string Username { get; set; }

    /// <summary>Gets or sets the password.</summary>
    /// <value>The password.</value>
    public string Password { get; set; }
}
