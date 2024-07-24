using AndOS.Core.Enums;
using System.Text.Json;

namespace AndOS.Shared.Requests.Accounts.Create;

public class CreateAccountRequest : IRequest<CreateAccountResponse>
{
    public CreateAccountRequest() { }

    public string Name { get; set; }
    public CloudStorage CloudStorage { get; set; }
    public JsonDocument Config { get; set; }
}