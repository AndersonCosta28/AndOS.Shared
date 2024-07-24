namespace AndOS.Shared.Requests.Files.Create;

public class CreateFileRequest : IRequest<CreateFileResponse>
{
    public CreateFileRequest() { }

    public CreateFileRequest(string name, string extension, string size, Guid parentFolderId)
    {
        Name = name;
        Extension = extension;
        Size = size;
        ParentFolderId = parentFolderId;
    }

    public string Name { get; set; }
    public string Extension { get; set; }
    public string Size { get; set; }
    public Guid ParentFolderId { get; set; }
}