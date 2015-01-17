using Northwind.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkIntro_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new NorthWindEntities();
            Console.WriteLine(db.Database.CreateIfNotExists());

        }
    }
}
