using AndOS.Core.Enums;

namespace AndOS.Shared.DTOs;

public class ChildrenFileDTO
{
    public ChildrenFileDTO() { }

    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Extension { get; set; }
    public string Icon { get; set; }
    public List<FilePermission> Permissions { get; set; }
}
