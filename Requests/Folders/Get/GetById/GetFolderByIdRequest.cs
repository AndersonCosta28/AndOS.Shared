namespace AndOS.Shared.Requests.Folders.Get.GetById;

public class GetFolderByIdRequest : IRequest<GetFolderByIdResponse>
{
    public GetFolderByIdRequest() { }

    public GetFolderByIdRequest(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; set; }
}