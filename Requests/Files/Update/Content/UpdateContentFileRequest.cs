namespace AndOS.Shared.Requests.Files.Update.Content;

public class UpdateContentFileRequest : IRequest<UpdateContentFileResponse>
{
    public Guid Id { get; set; }

    public UpdateContentFileRequest(Guid id)
    {
        Id = id;
    }
}