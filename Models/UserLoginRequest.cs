//UserLoginRequest.cs 

namespace JwtAuthForBooks.Models;

public class UserLoginRequest
{
    public string Username { get; set; }
    public string Password { get; set; }
}
