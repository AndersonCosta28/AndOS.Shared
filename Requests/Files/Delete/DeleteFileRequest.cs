namespace AndOS.Shared.Requests.Files.Delete;

public class DeleteFileRequest : IRequest
{
    public Guid Id { get; set; }

    public DeleteFileRequest() { }

    public DeleteFileRequest(Guid id)
    {
        Id = id;
    }
}