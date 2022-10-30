using News.Core.UI.Models;

namespace News.Core.UI.Services.Articles;

public interface IArticleService
{
    ValueTask<List<Article>> RetrieveAllArticlesAsync(Filter filter);
}
