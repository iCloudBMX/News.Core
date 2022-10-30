using News.Core.UI.Brokers.Apis;
using News.Core.UI.Models;

namespace News.Core.UI.Services.Articles;

public partial class ArticleService : IArticleService
{
    private readonly IApiBroker apiBroker;

    public ArticleService(IApiBroker apiBroker)
    {
        this.apiBroker = apiBroker;
    }

    public ValueTask<IEnumerable<Article>> RetrieveAllArticlesAsync(Filter filter) =>
    TryCatch(async () =>
    {
        ValidatePageSize(filter.PageSize);
        ValidatePositiveNumber(filter.Page);

        var articleCollection = await this.apiBroker
            .GetArticleCollectionAsync(filter);

        return articleCollection.Articles;
    });    
}