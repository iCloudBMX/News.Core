using News.Core.UI.Brokers.Apis.Exceptions;
using News.Core.UI.Extensions;
using News.Core.UI.Models;
using System.Text;

namespace News.Core.UI.Brokers.Apis;

public partial class ApiBroker
{
    private const string baseUrl = @"https://newsapi.org/v2/everything?apiKey=1a1d1edff0ce4c5887cd79f250464db0";
    
    public async ValueTask<IEnumerable<Article>> GetAllArticlesAsync(
        Filter filter)
    {
        StringBuilder relativeStringBuilder = new StringBuilder(baseUrl);
        relativeStringBuilder.GetRelativeUrl(filter);

        var apiReponse = await this.GetAsync<ApiResponse>(relativeStringBuilder.ToString());

        if (apiReponse.Status.ToUpper() == "ERROR")
            throw new ErrorResponseException(apiReponse.Message ?? "Something went wrong");

        return apiReponse.Articles;
    }
}