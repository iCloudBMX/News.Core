using News.Core.UI.Models;
using News.Core.UI.Services.Articles;

namespace News.Core.UI.Views.Articles;

public class ArticleView
{
	private readonly IArticleService articleService;
	private string[] options = new string[] { "From", "To", "QParameter", "Language", "SortBy" };

	public ArticleView(IArticleService articleService)
	{
		this.articleService = articleService;
	}

	public async ValueTask PrintArticles()
	{
		PrintFilterOptions();

		bool isParsed = int.TryParse(Console.ReadLine(), out int option);

		if (!isParsed)
			Console.WriteLine("Value cannot be parsed to integer");

		Console.Write($"Enter the value for {options[option - 1]}: ");
		var value = Console.ReadLine();

		var filter = option switch
		{
			3 => new Filter { QParameter = value },
			4 => new Filter { Language = value }
		};

		var articles = await this.articleService
			.RetrieveAllArticlesAsync(filter);

		PrintArticleTable(articles);
	}

	private void PrintArticleTable(List<Article> articles)
	{
		Console.WriteLine("=========== Article list ===========");
		Console.WriteLine("Id	Title");

		for(int articleIndex = 0; articleIndex < articles.Count; articleIndex++)
		{
			Console.WriteLine($"{articleIndex + 1}	{articles[articleIndex].Title}");
		}
	}

	private void PrintFilterOptions()
	{
		Console.WriteLine("=========== Article filter options ===========");
		
		for(int i = 0; i < options.Length; i++)
		{
			Console.WriteLine($"{i + 1}: {options[i]}");
		}
	}
}
