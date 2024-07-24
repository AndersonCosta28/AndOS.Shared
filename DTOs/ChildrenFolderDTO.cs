using AndOS.Core.Enums;

namespace AndOS.Shared.DTOs;

public class ChildrenFolderDTO
{
    public ChildrenFolderDTO() { }

    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Icon { get; set; }
    public List<FolderPermission> Permissions { get; set; }
}
