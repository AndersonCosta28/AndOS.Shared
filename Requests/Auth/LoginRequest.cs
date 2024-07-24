namespace AndOS.Shared.Requests.Auth;

public class LoginRequest : IRequest<string>
{
    public string Email { get; set; }
    public string Password { get; set; }
}
