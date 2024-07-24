namespace AndOS.Shared.Requests.Folders.Create;

public class CreateFolderRequest : IRequest<CreateFolderResponse>
{
    public CreateFolderRequest() { }

    public CreateFolderRequest(string name, Guid? parentFolderId)
    {
        Name = name;
        ParentFolderId = parentFolderId;
    }

    public string Name { get; set; }
    public Guid? ParentFolderId { get; set; }
}