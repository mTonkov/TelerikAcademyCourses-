using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.AddNewProduct
{/*Write a method that adds a new product in the products table in the Northwind database. 
  * Use a parameterized SQL command*/
    public class AddNewProduct
    {
        static void Main(string[] args)
        {
            int addedID = AddProduct("kyufte", "mnogo", 0);
            Console.WriteLine("Product with id {0} was added!", addedID);
        }

        public static int AddProduct(string productName, string quantity, int isDiscontinued)
        {
            SqlConnection dbConnection = new SqlConnection(Settings1.Default.DBConnectionString);
            dbConnection.Open();

            using (dbConnection)
            {
                SqlCommand command = new SqlCommand("INSERT INTO Products(ProductName, QuantityPerUnit, Discontinued) " +
            "VALUES (@name, @quantity, @isDiscontinued)", dbConnection);

                command.Parameters.AddWithValue("@name", productName);
                SqlParameter sqlQuantity = new SqlParameter("@quantity", quantity);
                if (string.IsNullOrEmpty(quantity))
                {
                    sqlQuantity.Value = DBNull.Value;
                }
                command.Parameters.Add(sqlQuantity);
                command.Parameters.AddWithValue("@isDiscontinued", isDiscontinued);
                command.ExecuteNonQuery();

                SqlCommand addedProductID = new SqlCommand("SELECT @@Identity", dbConnection);
                int insertedRecordId = (int)(decimal)addedProductID.ExecuteScalar();
                return insertedRecordId;
            }
        }
    }
}
