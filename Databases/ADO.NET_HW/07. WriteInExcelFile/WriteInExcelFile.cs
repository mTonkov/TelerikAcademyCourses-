using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.WriteInExcelFile
{
    class WriteInExcelFile
    {
        static void Main(string[] args)
        {
            AddInExcel("Stamat Stamatov", 13);
        }

        public static void AddInExcel(string name, int score)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\..\Scores.xlsx; Extended Properties=""Excel 12.0 Xml;HDR=YES;""";

            OleDbConnection xlsConnection = new OleDbConnection(connectionString);
            xlsConnection.Open();

            using (xlsConnection)
            {
                OleDbCommand command = new OleDbCommand("INSERT INTO [Sheet1$] (Name, Score) VALUES(@name, @score)", xlsConnection);

                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@score", score);

                command.ExecuteNonQuery();
            }
        }
    }
}
