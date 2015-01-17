using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.WorkWithMySQL
{
    class WorkWithMySQL
    {
        private static string connectionString = "Server=localhost;Database=library;Uid=root;Pwd=1235;";

        static void Main(string[] args)
        {
            // You must change Pwd value (Password) in the vonnection string above

            AddBook("Inferno", "Dan Brown", DateTime.Now, "1234-5678-9123");
            FindBooksByName("Christmas");
            ListingAllBooks();
        }

        private static void AddBook(string title, string author, DateTime publishDate, string isbn)
        {
            Console.WriteLine("Adding books: ");
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);

            mySqlConnection.Open();
            using (mySqlConnection)
            {
                MySqlCommand mySqlCommand = new MySqlCommand(@"INSERT INTO Books (Title, Author, PublishDate, ISBN)
                                                           VALUES (@title, @author, @publishDate, @isbn)", mySqlConnection);


                mySqlCommand.Parameters.AddWithValue("@title", title);
                mySqlCommand.Parameters.AddWithValue("@author", author);
                mySqlCommand.Parameters.AddWithValue("@publishDate", publishDate);
                MySqlParameter dateTimeParam = new MySqlParameter("publishDate", MySqlDbType.DateTime);
                dateTimeParam.Value = publishDate;
                mySqlCommand.Parameters.AddWithValue("@isbn", isbn);

                mySqlCommand.ExecuteNonQuery();
            }
        }

        private static void FindBooksByName(string substring)
        {
            Console.WriteLine("\nFinding books by name '{0}':", substring);

            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();

            using (mySqlConnection)
            {
                MySqlCommand mySqlCommand = new MySqlCommand(@"SELECT Title, Author, PublishDate, ISBN
                                                           FROM Books
                                                           WHERE LOCATE(@substring, Title)", mySqlConnection);

                mySqlCommand.Parameters.AddWithValue("@substring", substring);

                MySqlDataReader reader = mySqlCommand.ExecuteReader();
                using (reader)
                {
                    if (reader.Read())
                    {
                        do
                        {
                            var title = reader["Title"].ToString();
                            var author = reader["Author"].ToString();
                            var publishDate = (DateTime)reader["PublishDate"];
                            var isbn = reader["ISBN"].ToString();

                            Console.WriteLine("-> {0} by {1}, published on {2}, ISBN: {3}", title, author, publishDate, isbn);
                        } while (reader.Read());
                    }
                    else
                    {
                        Console.WriteLine("No such book");
                        Console.WriteLine();
                    }
                }
            }
        }

        private static void ListingAllBooks()
        {
            Console.WriteLine("Listing all books: ");
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);

            mySqlConnection.Open();
            using (mySqlConnection)
            {

                MySqlCommand mySqlCommand = new MySqlCommand(@"SELECT Title, Author, PublishDate, ISBN
                                                           FROM Books", mySqlConnection);

                MySqlDataReader reader = mySqlCommand.ExecuteReader();
                using (reader)
                {
                    if (reader.Read())
                    {
                        do
                        {
                            var title = reader["Title"].ToString();
                            var author = reader["Author"].ToString();
                            var publishDate = (DateTime)reader["PublishDate"];
                            var isbn = reader["ISBN"].ToString();

                            Console.WriteLine("-> {0} by {1}, published on {2}, ISBN: {3}", title, author, publishDate, isbn);

                        } while (reader.Read());
                    }
                    else
                    {
                        Console.WriteLine("No books");
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
