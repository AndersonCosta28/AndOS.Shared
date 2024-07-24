
namespace AndOS.Shared.Requests.Accounts.Get.GetById;

public class GetAccountByIdRequest : IRequest<GetAccountByIdResponse>
{
    public Guid Id { get; set; }

    public GetAccountByIdRequest() { }

    public GetAccountByIdRequest(Guid id)
    {
        Id = id;
    }
}