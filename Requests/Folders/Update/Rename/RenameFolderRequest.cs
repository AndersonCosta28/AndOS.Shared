namespace AndOS.Shared.Requests.Folders.Update.Rename;

public class RenameFolderRequest : IRequest
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public RenameFolderRequest() { }

    public RenameFolderRequest(Guid id, string name)
    {
        Id = id;
        Name = name;
    }
}