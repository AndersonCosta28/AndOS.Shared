using AndOS.Core.Enums;

namespace AndOS.Shared.Requests.Files.Get.GetById;

public class GetFileByIdResponse : FileDTO
{
    public GetFileByIdResponse() { }
    public string Url { get; set; }
    public CloudStorage CloudStorage { get; set; }

    public GetFileByIdResponse(string url, CloudStorage cloudStorage)
    {
        Url = url;
        CloudStorage = cloudStorage;
    }
}