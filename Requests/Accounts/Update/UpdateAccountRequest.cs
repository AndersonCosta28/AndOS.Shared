using AndOS.Core.Enums;
using System.Text.Json;

namespace AndOS.Shared.Requests.Accounts.Update;

public class UpdateAccountRequest : IRequest
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public CloudStorage CloudStorage { get; set; }
    public JsonDocument Config { get; set; }
}