namespace AndOS.Shared.Requests.Folders.Create;

public class CreateFolderResponse
{
    public Guid Id { get; set; }

    public CreateFolderResponse()
    {

    }
    public CreateFolderResponse(Guid id)
    {
        Id = id;
    }
}