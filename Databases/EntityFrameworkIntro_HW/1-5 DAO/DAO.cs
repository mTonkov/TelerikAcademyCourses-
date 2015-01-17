using Northwind.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{/*
 1. Using the Visual Studio Entity Framework designer create a DbContext for the Northwind database
 2. Create a DAO class with static methods which provide functionality for inserting, modifying and deleting customers. Write a testing class.
 3. Write a method that finds all customers who have orders made in 1997 and shipped to Canada
 4. Implement previous by using native SQL query and executing it through the DbContext.
 5. Write a method that finds all the sales by specified region and period (start / end dates).

*/
    public class DAO
    {
        private static NorthWindEntities db = new NorthWindEntities();

        public static void Main(string[] args)
        {
            //AddCustomer("TLRK", "TELERIK");

            //ModifyEntry("TLRK", "TELERIK LTD.");

            //DeleteEntry("TLRK");

            //ShippedToCanada();

            //Console.WriteLine("Native query:");
            //ShippedToCanadaNativeSQLQuery();
            var start = new DateTime(1990, 1, 1);
            GetSalesByRegionAndPeriod("Lara", start, new DateTime(2014, 1, 1));
        }
        //Task 02
        public static void AddCustomer(string companyID, string companyName)
        {
            var newCustomer = new Customer();
            newCustomer.CustomerID = companyID;
            newCustomer.CompanyName = companyName;

            db.Customers.Add(newCustomer);
            db.SaveChanges();
        }
        //Task 02
        public static void ModifyEntry(string companyID, string newName)
        {
            var company = db.Customers.FirstOrDefault(c => c.CustomerID == companyID);
            company.CompanyName = newName;

            db.SaveChanges();
        }
        //Task 02
        public static void DeleteEntry(string companyID)
        {
            var company = db.Customers.FirstOrDefault(c => c.CustomerID == companyID);
            db.Customers.Remove(company);
            db.SaveChanges();
        }
        //Task 03
        public static void ShippedToCanada()
        {
            var customers = db.Customers
                .Join(db.Orders,
                c => c.CustomerID,
                o => o.CustomerID,
                (c, o) => new
                {
                    CustomerName = c.CompanyName,
                    OrderDate = o.OrderDate,
                    ShippedTo = o.ShipCountry
                }).Where(o => o.ShippedTo == "Canada" && o.OrderDate.Value.Year == 1997);

            foreach (var customer in customers)
            {
                Console.WriteLine("Customer: {0,-30}DateOfOrder: {1, -10 : dd.MM.yyyy} ShippedTo: {2}", customer.CustomerName, customer.OrderDate, customer.ShippedTo);
            }
        }
        //Task 04
        public static void ShippedToCanadaNativeSQLQuery()
        {
            string nativeQuery = @"SELECT c.CompanyName [CustomerName], o.OrderDate [OrderDate], o.ShipCountry [ShippedTo] " +
                                  "FROM Customers c                                                                        " +
                                  "INNER JOIN Orders o                                                                     " +
                                  "ON c.CustomerID = o.CustomerID                                                          " +
                                  "WHERE o.ShipCountry = 'Canada' AND year(o.OrderDate) = 1997";
            var customers = db.Database.SqlQuery<CustomerAndOrderInfo>(nativeQuery);


            foreach (var customer in customers)
            {
                Console.WriteLine("Customer: {0,-30}DateOfOrder: {1, -10 : dd.MM.yyyy} ShippedTo: {2}", customer.CustomerName, customer.OrderDate, customer.ShippedTo);
            }
        }
        //Task 05
        public static void GetSalesByRegionAndPeriod(string region, DateTime startDate, DateTime endDate)
        {

            var sales = db.Orders
                        .Where(o => o.ShipRegion == region &&
                                    o.OrderDate.Value > startDate &&
                                    o.OrderDate.Value < endDate)
                        .Select(o => new
                        {
                            o.ShipRegion,
                            o.OrderDate
                        })
                        .OrderBy(s => s.ShipRegion);

            Console.WriteLine("REGION - OrderDate");
            Console.WriteLine(new string('=', 20));

            foreach (var sale in sales)
            {
                Console.WriteLine("{0} - {1 : dd.MM.yyyy}", sale.ShipRegion, sale.OrderDate);
            }
        }

        internal class CustomerAndOrderInfo
        {
            public string CustomerName { get; set; }
            public DateTime OrderDate { get; set; }
            public string ShippedTo { get; set; }
        }
    }
}
