using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.DataFromExcel
{/*Create an Excel file with 2 columns: name and score
Write a program that reads your MS Excel file through the OLE DB data provider and displays the name and score row by row.
*/
    class DataFromExcel
    {
        static void Main(string[] args)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\..\Kindergarten109-25-Dec-2014.xls; Extended Properties=""Excel 12.0 Xml;HDR=YES;""";

            OleDbConnection xlsConnection = new OleDbConnection(connectionString);
            xlsConnection.Open();

            using (xlsConnection)
            {
                OleDbCommand command = new OleDbCommand("SELECT * FROM [Sheet1$B1:G6]", xlsConnection);

                OleDbDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        string name = (string)reader[0];
                        string score = (string)reader[4];

                        Console.WriteLine("{0} - {1}", name, score);
                    }
                }
            }
        }
    }
}
