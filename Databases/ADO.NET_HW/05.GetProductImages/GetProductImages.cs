using _04.AddNewProduct;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.GetProductImages
{/*Write a program that retrieves the images for all categories in the Northwind database and 
  * stores them as JPG files in the file system*/
    class GetProductImages
    {
        static void Main(string[] args)
        {
            SqlConnection dbConnection = new SqlConnection(Settings1.Default.DBConnectionString);
            dbConnection.Open();

            using (dbConnection)
            {
                SqlCommand cmd = new SqlCommand("SELECT Picture FROM Categories", dbConnection);

                SqlDataReader reader = cmd.ExecuteReader();

                int imageNumber = 0;
                using (reader)
                {
                    while (reader.Read())
                    {
                        WriteBinaryFile("..\\..\\image - " + imageNumber++ + ".jpg", (byte[])reader["Picture"]);
                    }
                }
            }
        }

        private static void WriteBinaryFile(string fileName, byte[] fileContents)
        {
            FileStream stream = File.OpenWrite(fileName);
            using (stream)
            {
                stream.Write(fileContents, 0, fileContents.Length);
            }
        }

    }
}
