namespace AndOS.Shared.Requests.Files.Update.Content;

public class UpdateContentFileResponse
{
    public UpdateContentFileResponse() { }

    public UpdateContentFileResponse(string url)
    {
        Url = url;
    }
    public string Url { get; set; }
}