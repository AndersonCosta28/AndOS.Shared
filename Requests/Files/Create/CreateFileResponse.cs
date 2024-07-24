using AndOS.Core.Enums;

namespace AndOS.Shared.Requests.Files.Create;

public class CreateFileResponse
{
    public Guid Id { get; set; }
    public string Url { get; set; }
    public CloudStorage CloudStorage { get; set; }

    public CreateFileResponse() { }

    public CreateFileResponse(Guid id, string url, CloudStorage cloudStorage)
    {
        Id = id;
        Url = url;
        CloudStorage = cloudStorage;
    }
}