namespace News.Core.UI.Models;

public class Filter
{
    public string? QParameter { get; set; }
    public DateTime? From { get; set; }
    public DateTime? To { get; set; }
    public string? Language { get; set; }
    public string? SortBy { get; set; }
    public int PageSize { get; set; } = 10;
    public int Page { get; set; } = 1;
}