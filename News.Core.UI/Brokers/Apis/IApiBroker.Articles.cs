using News.Core.UI.Models;

namespace News.Core.UI.Brokers.Apis;

public partial interface IApiBroker
{
    ValueTask<(int TotalPages, List<Article> Articles)> GetArticleCollectionAsync(Filter filter);
}
