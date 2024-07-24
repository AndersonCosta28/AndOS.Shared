using AndOS.Core.Enums;
namespace AndOS.Shared.DTOs;

public class AccountDTO
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public CloudStorage CloudStorage { get; set; }
    public FolderAccountDTO Folder { get; set; }
}

public class FolderAccountDTO
{
    public Guid Id { get; set; }
    public string Name { get; set; }
}