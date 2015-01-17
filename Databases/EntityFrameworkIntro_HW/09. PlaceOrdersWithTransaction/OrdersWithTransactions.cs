using Northwind.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.PlaceOrdersWithTransaction
{/*Create a method that places a new order in the Northwind database. 
  * The order should contain several order items. 
  * Use transaction to ensure the data consistency*/
    class OrdersWithTransactions
    {
        static void Main(string[] args)
        {
            using (var db = new NorthWindEntities())
            {
                using (var scope = db.Database.BeginTransaction())
                {
                    try
                    {
                        var invalidOrder = new Order();
                        invalidOrder.CustomerID = "SOOOINVALID";

                        db.Orders.Add(invalidOrder);

                        var validOrder = new Order();
                        validOrder.CustomerID = "VINET";

                        db.Orders.Add(validOrder);

                        db.SaveChanges();
                        scope.Commit();
                    }
                    catch (Exception)
                    {
                        scope.Rollback();
                    }
                }
            }
        }
    }
}
