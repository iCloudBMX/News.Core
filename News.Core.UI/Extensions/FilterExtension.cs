using News.Core.UI.Models;
using System.Text;

namespace News.Core.UI.Extensions;

public static class FilterExtension
{
    public static void GetRelativeUrl(
        this StringBuilder relativeUrlBuilder,
        Filter filter)
    {
        if (filter.QParameter != null)
            relativeUrlBuilder.Append($"&q={filter.QParameter}");

        if (filter.Language != null)
            relativeUrlBuilder.Append($"&language={filter.Language}");

        if (filter.From != null)
            relativeUrlBuilder.Append($"&from={filter.From}");
        
        if (filter.To != null)
            relativeUrlBuilder.Append($"&to={filter.To}");

        if (filter.SortBy != null)
            relativeUrlBuilder.Append($"&sortBy={filter.SortBy}");

        relativeUrlBuilder
            .Append($"&pageSize={filter.PageSize}&page={filter.Page}");
    }
}
