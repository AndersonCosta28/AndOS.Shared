namespace AndOS.Shared.Requests.Auth.Login;

public class LoginRequest : IRequest<LoginResponse>
{
    public string Email { get; set; }
    public string Password { get; set; }
}
