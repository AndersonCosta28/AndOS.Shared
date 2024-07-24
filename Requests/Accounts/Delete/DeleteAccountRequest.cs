namespace AndOS.Shared.Requests.Accounts.Delete;

public class DeleteAccountRequest : IRequest
{
    public Guid Id { get; set; }
}