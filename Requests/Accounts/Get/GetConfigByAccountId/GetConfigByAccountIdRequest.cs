using System.Text.Json;

namespace AndOS.Shared.Requests.Accounts.Get.GetConfigByAccountId;

public class GetConfigByAccountIdRequest : IRequest<JsonDocument>
{
    public Guid AccountId { get; set; }

    public GetConfigByAccountIdRequest() { }

    public GetConfigByAccountIdRequest(Guid accountId)
    {
        AccountId = accountId;
    }
}