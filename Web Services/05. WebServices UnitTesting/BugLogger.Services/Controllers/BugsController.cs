using BugLogger.Data;
using BugLogger.Data.Contracts;
using BugLogger.Models;
using BugLogger.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BugLogger.Services.Controllers
{
    public class BugsController : ApiController
    {
        private IBugLoggerData dataProvider;

        public BugsController()
            : this(new BugLoggerData())
        {
        }

        public BugsController(IBugLoggerData data)
        {
            this.dataProvider = data;
        }

        [HttpGet]
        public IHttpActionResult GetAllBugs()
        {
            var allBugs = this.dataProvider.Bugs.All();

            return Ok(allBugs);
        }

        [HttpGet]
        public IHttpActionResult GetAllBugsAfterDate([FromUri]DateTime date)
        {
            var allBugs = this.dataProvider.Bugs
                .All()
                .Where(b => b.LogDate>= date);

            return Ok(allBugs);
        }

        [HttpGet]
        public IHttpActionResult GetSpecificStatusBugs([FromUri]string type)
        {
            var allBugs = this.dataProvider.Bugs
                .All()
                .Where(b => b.BugStatus.ToString().ToLower() == type.ToLower());

            return Ok(allBugs);
        }

        [HttpPost]
        public HttpResponseMessage PostBug(PostBugModel bug)
        {
            if (string.IsNullOrEmpty(bug.Text))
            {
                var ex = new ArgumentException();
                return this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }

            var newBug = new Bug
            {
                Text = bug.Text
            };

            newBug.LogDate = DateTime.Now;
            newBug.BugStatus = Status.Pending;
            this.dataProvider.Bugs.Add(newBug);
            this.dataProvider.SaveChanges();

            var response = this.Request.CreateResponse(HttpStatusCode.Created, bug);
            response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = newBug.Id }));
            return response;
        }

    }
}
