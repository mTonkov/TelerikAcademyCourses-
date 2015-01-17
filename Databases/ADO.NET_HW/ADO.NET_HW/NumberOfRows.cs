using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADO.NET_HW
{/*01.
  Write a program that retrieves from the Northwind sample database in MS SQL Server the number of rows in the Categories table.
*/
    public class NumberOfRows
    {
        static void Main(string[] args)
        {// if connection fails, check "Northwind" spelling
            SqlConnection dbConnection = new SqlConnection("Server=.\\SQLEXPRESS; Database=Northwind; Integrated Security=true");
            dbConnection.Open();

            using (dbConnection)
            {
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Categories", dbConnection);
                int numberOfRows = (int)command.ExecuteScalar();
                Console.WriteLine("Rows count: {0} ", numberOfRows);
                Console.WriteLine();
            }
        }
    }
}
