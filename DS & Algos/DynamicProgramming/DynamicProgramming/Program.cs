using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{/*Write a program based on dynamic programming to solve the "Knapsack Problem": you are given N products, 
  * each has weight Wi and costs Ci and a knapsack of capacity M 
  * and you want to put inside a subset of the products with highest cost and weight ≤ M.
  * The numbers N, M, Wi and Ci are integers in the range [1..500]. Example: M=10 kg, N=6, products:
beer – weight=3, cost=2
vodka – weight=8, cost=12
cheese – weight=4, cost=5
nuts – weight=1, cost=4
ham – weight=2, cost=3
whiskey – weight=8, cost=13
*/
    class Program
    {
        static void Main(string[] args)
        {
            /*
              6
              10
              beer 3 2
              vodka 8 12
              cheese 4 5
              nuts 1 4
              ham 2 3
              whiskey 8 13
             */
            Console.WriteLine("Number of products for the Knapsack?");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("The weight limit of the products for the Knapsack?");
            int maxWeight = int.Parse(Console.ReadLine());

            var allProducts = new List<Product>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter a product name, weight and cost in the same order, separated by space");
                string[] productInput = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);

                allProducts.Add(new Product
                {
                    Name = productInput[0],
                    Weight = int.Parse(productInput[1]),
                    Cost = int.Parse(productInput[2])
                });
            }

           allProducts = allProducts.OrderByDescending(p => p.Cost).ToList();

            int gainedWeight = 0;
            var listOfProductsForKnapsack = new List<Product>();
            for (int i = 0; i < allProducts.Count; i++)
            {
                var currentProduct = allProducts[i];
                if (currentProduct.Weight <= maxWeight && currentProduct.Weight + gainedWeight <= maxWeight)
                {
                    gainedWeight += currentProduct.Weight;
                    listOfProductsForKnapsack.Add(currentProduct);
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Products in knapsack");
            foreach (var product in listOfProductsForKnapsack)
            {
                Console.WriteLine("{0} Weight:{1} Cost:{2} ", product.Name, product.Weight, product.Cost);
            }
        }
    }
}
