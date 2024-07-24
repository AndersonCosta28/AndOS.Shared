namespace AndOS.Shared.DTOs;

public class SystemItemDTO
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Icon { get; set; }
    public string FullPath { get; set; }
    public string CurrentPath { get; set; }
    public ParentFolderDTO ParentFolder { get; set; }

    static System.Text.Json.JsonSerializerOptions options = new()
    {
        WriteIndented = true,
    };

    public override string ToString()
    {
        return System.Text.Json.JsonSerializer.Serialize(this, options);
    }
}