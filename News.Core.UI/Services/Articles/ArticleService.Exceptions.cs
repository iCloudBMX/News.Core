using News.Core.UI.Models;

namespace News.Core.UI.Services.Articles;

public partial class ArticleService
{
    private delegate ValueTask<IEnumerable<Article>> ReturningArticlesFunction();

    private async ValueTask<IEnumerable<Article>> TryCatch(ReturningArticlesFunction returningArticlesFunction)
    {
        throw new NotImplementedException();
    }
}