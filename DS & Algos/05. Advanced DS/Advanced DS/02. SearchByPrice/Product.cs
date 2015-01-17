using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SearchByPrice
{
    public class Product : IComparable
    {
        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }

        public int CompareTo(object obj)
        {
            if (obj == null) 
            { 
                return 1; 
            }

            var other = obj as Product;
            if (other != null)
            {
                return this.Price.CompareTo(other.Price);
            }
            else
            {
                throw new ArgumentException("Object is not a Product"); 
            }
        }
    }
}
