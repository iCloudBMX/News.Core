namespace News.Core.UI.Models;

public class ApiResponse
{
    public string Status { get; set; }
    public string? Code { get; set; }
    public string? Message { get; set; }
    public int? TotalResults { get; set; }
    public List<Article> Articles { get; set; }
}
