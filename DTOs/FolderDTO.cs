using AndOS.Core.Enums;

namespace AndOS.Shared.DTOs;

public class FolderDTO : SystemItemDTO
{
    public FolderDTO() { }

    public List<ChildrenFileDTO> Files { get; set; } = [];
    public List<ChildrenFolderDTO> Folders { get; set; } = [];
    public List<FolderPermission> Permissions { get; set; } = [];
    public FolderType Type { get; set; }
    public CloudStorage? CloudStorage { get; set; }
}