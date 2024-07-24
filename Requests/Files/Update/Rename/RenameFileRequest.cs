namespace AndOS.Shared.Requests.Files.Update.Rename;

public class RenameFileRequest : IRequest
{
    public Guid Id { get; set; }

    public string Name { get; set; }
    public string Extension { get; set; }

    public RenameFileRequest() { }

    public RenameFileRequest(Guid id, string name, string extension)
    {
        Id = id;
        Name = name;
        Extension = extension;
    }
}