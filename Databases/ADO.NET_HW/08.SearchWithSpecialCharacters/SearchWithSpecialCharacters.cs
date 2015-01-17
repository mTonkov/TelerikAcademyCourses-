using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SearchWithSpecialCharacters
{
    class SearchWithSpecialCharacters
    {
        public static void Main()
        {
            Console.Write("Enter a search string: ");
            var pattern = Console.ReadLine();

            SearchProduct(pattern);
        }

        private static void SearchProduct(string pattern)
        {
            var dbConnection = new SqlConnection(Settings1.Default.DBConnectionString);
            using (dbConnection)
            {
                dbConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(@"SELECT ProductName
                                                     FROM Products
                                                     WHERE CHARINDEX(@pattern, ProductName) > 0", dbConnection);
                sqlCommand.Parameters.AddWithValue("@pattern", pattern);

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productName = reader["ProductName"];

                        Console.WriteLine(" - " + productName);
                    }
                }
            }
        }
    }
}
