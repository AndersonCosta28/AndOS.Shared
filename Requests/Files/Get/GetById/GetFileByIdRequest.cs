namespace AndOS.Shared.Requests.Files.Get.GetById;

public class GetFileByIdRequest : IRequest<GetFileByIdResponse>
{
    public Guid Id { get; set; }

    public GetFileByIdRequest() { }

    public GetFileByIdRequest(Guid id)
    {
        Id = id;
    }
}