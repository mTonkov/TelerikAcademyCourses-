using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AllCategoriesAllProducts
{/*Write a program that retrieves from the Northwind database all product categories 
  * and the names of the products in each category. 
  * Can you do this with a single SQL query (with table join)?
*/
    public class AllCategoriesAllProducts
    {
        static void Main(string[] args)
        {
            SqlConnection dbConnection = new SqlConnection("Server=.\\SQLEXPRESS; Database=Northwind; Integrated Security=true");
            dbConnection.Open();

            using (dbConnection)
            {
                SqlCommand command = new SqlCommand("SELECT [c].[CategoryName], [p].[ProductName] " +
                                                    "FROM [NORTHWIND].[dbo].[Categories] AS [c] " +
                                                    "INNER JOIN [NORTHWIND].[dbo].[Products] AS [p] " +
                                                    "ON [c].[CategoryID] = [p].[CategoryID] " +
                                                    "ORDER BY [c].[CategoryName]", dbConnection);

                SqlDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        string categoryName = (string)reader["CategoryName"];
                        string productName = (string)reader["ProductName"];

                        Console.WriteLine("{0, -20} - {1}", categoryName, productName);
                    }
                }
            }
        }
    }
}
