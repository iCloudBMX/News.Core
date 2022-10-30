namespace News.Core.UI.Services.Articles;

public partial class ArticleService
{
    private const int TOTAL_PAGE_SIZE = 100;

    private void ValidatePositiveNumber(int number)
    {
        if (number <= 0)
            throw new ArgumentOutOfRangeException("Given number should be greater than 0");
    }

    private void ValidatePageSize(int pageSize)
    {
        ValidatePositiveNumber(pageSize);

        if (pageSize > TOTAL_PAGE_SIZE)
            throw new ArgumentOutOfRangeException("Given size cannot be greater than total size");
    }
}