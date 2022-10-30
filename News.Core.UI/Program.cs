using News.Core.UI.Brokers.Apis;
using News.Core.UI.Services.Articles;
using News.Core.UI.Views.Articles;

namespace News.Core.UI
{
    internal class Program
    {
        private static string[] options = new string[] { "Articles" };

        static async Task Main(string[] args)
        {
            Console.WriteLine("=========== Welcome to news channel ===========");
            
            for(int i = 0; i < options.Length; i++)
            {
                Console.WriteLine($"{i + 1}: {options[i]}");
            }

            bool isParsed = int.TryParse(Console.ReadLine(), out int option);

            if (!isParsed)
                Console.WriteLine("Value cannot be parsed to integer");
            
            if(option == 1)
                await CallArticleView();
        }

        public async static ValueTask CallArticleView()
        {
            Console.Clear();

            var apiBroker = new ApiBroker();
            var articleService = new ArticleService(apiBroker);
            var articleView = new ArticleView(articleService);

            await articleView.PrintArticles();
        }
    }
}