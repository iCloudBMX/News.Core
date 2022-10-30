using News.Core.UI.Models;

namespace News.Core.UI.Brokers.Apis;

public partial interface IApiBroker
{
    ValueTask<IEnumerable<Article>> GetAllArticlesAsync(Filter filter);
}
