using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Http;
using Telerik.JustMock;
using BugLogger.Models;
using BugLogger.Data.Contracts;
using BugLogger.Services.Controllers;
using System.Net.Http;
using System.Threading;
using System.Collections.Generic;
using System.Web.Http.Routing;

namespace BugLogger.Services.Tests
{
    [TestClass]
    public class ControllerTests
    {
        [TestMethod]
        public void TestIfControllerGetsAllBugs()
        {
            var repo = Mock.Create<IBugLoggerData>();

            Bug[] bugs =
            {
                new Bug() { Text = "Bug1" },
                new Bug() { Text = "Bug2" }
            };

            Mock.Arrange(() => repo.Bugs.All())
                .Returns(() => bugs.AsQueryable());

            var controller = new BugsController(repo);
            this.SetupController(controller);

            //act
            var result = controller.GetAllBugs().ExecuteAsync(CancellationToken.None).Result;
            var final = result.Content.ReadAsAsync<IEnumerable<Bug>>().Result.ToArray();

            //assert
            CollectionAssert.AreEquivalent(bugs, final);
        }

        private void SetupController(ApiController controller)
        {
            string serverUrl = "http://test-url.com";

            //Setup the Request object of the controller
            var request = new HttpRequestMessage()
            {
                RequestUri = new Uri(serverUrl)
            };
            controller.Request = request;

            //Setup the configuration of the controller
            var config = new HttpConfiguration();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional });
            controller.Configuration = config;

            //Apply the routes of the controller
            controller.RequestContext.RouteData =
                new HttpRouteData(
                    route: new HttpRoute(),
                    values: new HttpRouteValueDictionary
                    {
                        { "controller", "bug" }
                    });
        }

    }
}
