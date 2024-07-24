using AndOS.Core.Enums;

namespace AndOS.Shared.DTOs;

public class FileDTO : SystemItemDTO
{
    public string Size { get; set; }
    public string Extension { get; set; }
    public List<FilePermission> Permissions { get; set; } = [];
}