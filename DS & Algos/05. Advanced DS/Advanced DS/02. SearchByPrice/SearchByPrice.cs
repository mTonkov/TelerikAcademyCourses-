using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace _02.SearchByPrice
{
    public class SearchByPrice
    {
        private static OrderedBag<Product> allProducts;
        static void Main()
        {
            allProducts = new OrderedBag<Product>();

            for (int i = 0; i < 500000; i++)
            {
                allProducts.Add(new Product("Product", i));
            }

            foreach (var product in GetProductsInPriceRange(450000, 460000))
            {
                Console.WriteLine(product.Name + " : " + product.Price);
            }
        }

        public static ICollection<Product> GetProductsInPriceRange(decimal start, decimal end)
        {
            var firstInRange = allProducts.FirstOrDefault(p => p.Price == start);
            int indexStart = allProducts.IndexOf(firstInRange);
            var lastInRange = allProducts[indexStart + 20];

            return allProducts.Range(firstInRange, true, lastInRange, true);
        }
    }
}
