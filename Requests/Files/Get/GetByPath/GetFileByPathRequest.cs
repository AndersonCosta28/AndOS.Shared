namespace AndOS.Shared.Requests.Files.Get.GetByPath;

public class GetFileByPathRequest : IRequest<GetFileByPathResponse>
{
    public string Path { get; set; }
}