using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Transactions;
using BugLogger.Models;
using BugLogger.Data;
using System.Web.Http;
using System.Net.Http;
using System.Web.Http.Routing;
using System.Collections;

namespace BugLogger.Services.Tests
{
    [TestClass]

    public class RepositoriesTests
    {
        static TransactionScope tran;

        [TestInitialize]
        public void TestInit()
        {
            tran = new TransactionScope();
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            tran.Dispose();
        }


        [TestMethod]
        public void AddNewBugTest()
        {
            var bug = new Bug
            {
                Text = "Test Bug",
                BugStatus = Status.Pending,
                LogDate = DateTime.Now
            };

            var repo = new BugLoggerData();
            repo.Bugs.Add(bug);
            repo.SaveChanges();

            var addedBug = repo.Bugs.All().FirstOrDefault(b => b.Id == bug.Id);

            Assert.IsNotNull(addedBug);
            Assert.AreEqual(bug.Text, addedBug.Text);
        }

    }
}
