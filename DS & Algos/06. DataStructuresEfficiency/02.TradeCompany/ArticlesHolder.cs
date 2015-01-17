using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Wintellect.PowerCollections;
namespace _02.TradeCompany
{
    public class ArticlesHolder
    {
        private OrderedMultiDictionary<decimal, Article> holder;

        public void Add(Article newArticle)
        {
            this.holder.Add(newArticle.Price, newArticle);
        }

        public IEnumerable<Article> Find(decimal lowerEnd, decimal higherEnd)
        {
            var searchedArticles = holder.FindAll(pair => pair.Key >= lowerEnd && pair.Key <= higherEnd);

            var result = new List<Article>();
            foreach (var priceArticlePair in searchedArticles)
            {
                result.Union(priceArticlePair.Value);
            }

            return result;
        }
    }
}
