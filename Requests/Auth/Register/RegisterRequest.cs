namespace AndOS.Shared.Requests.Auth.Register;

public class RegisterRequest : IRequest
{
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}
