using _11.ForumSystem.Data;
using _11.ForumSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ForumSystem.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new ForumSystemContext();
            Console.WriteLine(db.Database.CreateIfNotExists());


            using (db)
            {
                using (var tran = db.Database.BeginTransaction())
                {
                    try
                    {
                        var user = new User();
                        user.Nickname = "hackera";

                        db.Users.Add(user);

                        var adminGroup = db.Groups.FirstOrDefault(g => g.Name == "Admin");

                        if (adminGroup == null)
                        {
                            adminGroup = new Group();
                            adminGroup.Name = "Admin";
                            db.Groups.Add(adminGroup);
                        }

                        user.Group = adminGroup;
                        db.SaveChanges();
                        tran.Commit();
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("213");
                        tran.Rollback();
                    }
                }


                Console.WriteLine(db.Users.Count());
                Console.WriteLine(db.Groups.Count());
            }
        }
    }
}
