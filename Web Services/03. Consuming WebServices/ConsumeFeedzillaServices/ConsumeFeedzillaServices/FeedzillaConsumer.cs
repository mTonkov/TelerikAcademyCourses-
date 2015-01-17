using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeFeedzillaServices
{
    class FeedzillaConsumer
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, provide a search criteria to search in the articles and/or press 'Enter'");
            var criteria = Console.ReadLine();

            Console.WriteLine("Please, provide the number of results you would like to view and/or press 'Enter'");
            int count;
            try
            {
                count = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                count = 0;
            }

            var articles = ReadArticles(criteria, count);

            foreach (var article in articles)
            {
                Console.WriteLine("Title: {0}", article.Title);
                Console.WriteLine("\tURL: {0}", article.URL);
                Console.WriteLine();
            }
        }

        private static IEnumerable<ArticlesConsumeModel> ReadArticles(string criteria, int top)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://api.feedzilla.com/v1/articles/search.json");

            HttpResponseMessage response;
            if (!string.IsNullOrEmpty(criteria) && top > 0)
            {
                response = client.GetAsync(string.Format("?q={0}&count={1}", criteria, top)).Result;
            }
            else if (!string.IsNullOrEmpty(criteria))
            {
                response = client.GetAsync(string.Format("?q={0}", criteria)).Result;
            }
            else
            {
                response = client.GetAsync(string.Format("?count={0}", top)).Result;
            }

            var finalResponseResult = response.Content.ReadAsStringAsync().Result;

            var articlesArray = JObject.Parse(finalResponseResult);
            return JsonConvert.DeserializeObject<IEnumerable<ArticlesConsumeModel>>(articlesArray["articles"].ToString());
        }
    }
}
