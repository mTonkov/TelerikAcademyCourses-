using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace _02.NameAndDescriptionOfCategories
{/*02. Write a program that retrieves the name and description of all categories in the Northwind DB.
*/
    class NameAndDescriptionOfCategories
    {
        static void Main(string[] args)
        {
            SqlConnection dbConnection = new SqlConnection("Server=.\\SQLEXPRESS; Database=Northwind; Integrated Security=true");
            dbConnection.Open();

            using (dbConnection)
            {
                SqlCommand command = new SqlCommand("SELECT CategoryName, Description FROM Categories", dbConnection);

                SqlDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        string name = (string)reader["CategoryName"];
                        string description = (string)reader["Description"];

                        Console.WriteLine("{0} - {1}", name, description);
                    }
                }
            }
        }
    }
}
