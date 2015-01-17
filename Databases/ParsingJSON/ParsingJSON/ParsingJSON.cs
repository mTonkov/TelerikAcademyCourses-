using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml.Linq;

namespace ParsingJSON
{
    class ParsingJSON
    {
        static void Main(string[] args)
        {
            string address = @"http://forums.academy.telerik.com/feed/qa.rss";
            string rssFeedLocation = @"..\\..\\rssFeed.xml";
            //task 02
            var rss = new WebClient();
            rss.DownloadFile(address, rssFeedLocation);

            var feed = XElement.Load(rssFeedLocation);

            //task 03
            var jsonFeed = JsonConvert.SerializeXNode(feed, Newtonsoft.Json.Formatting.Indented);
            var jsonObj = JObject.Parse(jsonFeed);

            //task 04
            var titles = jsonObj["rss"]["channel"]["item"]
                                .Select(item => item["title"]);

            foreach (var title in titles)
            {
                Console.WriteLine(title);
            }

            // task 05
            var items = jsonObj["rss"]["channel"]["item"];
            var topics = JsonConvert.DeserializeObject<List<ForumTopic>>(items.ToString());

            // task 06
            var htmlWriter = new StreamWriter("..\\..\\index.html", false, Encoding.Unicode);

            using (htmlWriter)
            {

                htmlWriter.WriteLine("<!DOCTYPE html>");
                htmlWriter.WriteLine("<html>");
                htmlWriter.WriteLine("<body>");
                htmlWriter.WriteLine("<ul>");

                foreach (var topic in topics)
                {
                    htmlWriter.WriteLine("<li>"+
                        "Title:<a href=\"{2}\">{0}</a>"+
                        "<br/> Categories: {1} <br/><br/>"+
                        "</li>", topic.Title, topic.Category, topic.Url);
                }

                htmlWriter.WriteLine("</ul>");
                htmlWriter.WriteLine("</body>");
                htmlWriter.WriteLine("</html>");
            }
        }
    }
}
