namespace AndOS.Shared.Requests.Folders.Delete;

public class DeleteFolderRequest : IRequest
{
    public DeleteFolderRequest() { }

    public DeleteFolderRequest(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; set; }
}