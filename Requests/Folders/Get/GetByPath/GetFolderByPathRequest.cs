namespace AndOS.Shared.Requests.Folders.Get.GetByPath;

public class GetFolderByPathRequest : IRequest<GetFolderByPathResponse>
{
    public GetFolderByPathRequest() { }

    public GetFolderByPathRequest(string path)
    {
        Path = path?.Trim() ?? string.Empty;
    }

    public string Path { get; set; }
}