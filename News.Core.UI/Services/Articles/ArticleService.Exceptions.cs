using News.Core.UI.Brokers.Apis.Exceptions;
using News.Core.UI.Models;
using News.Core.UI.Models.Articles;
using System;

namespace News.Core.UI.Services.Articles;

public partial class ArticleService
{
    private delegate ValueTask<List<Article>> ReturningArticlesFunction();

    private async ValueTask<List<Article>> TryCatch(ReturningArticlesFunction returningArticlesFunction)
    {
        try
        {
            return await returningArticlesFunction();
        }
        catch(ArgumentOutOfRangeException argumentOutOfRangeException)
        {
            throw new ServiceException(argumentOutOfRangeException.Message, argumentOutOfRangeException);
        }
        catch(ErrorResponseException errorResponseException)
        {
            throw new ServiceException(errorResponseException.Message, errorResponseException);
        }
        catch (Exception exception)
        {
            throw new ServiceException(exception.Message, exception);
        }
    }
}