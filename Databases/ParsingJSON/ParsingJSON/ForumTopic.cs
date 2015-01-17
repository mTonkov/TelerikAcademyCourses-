using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingJSON
{
    public class ForumTopic
    {

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public string Url { get; set; }
        
        [JsonProperty("category")]
        public string Category { get; set; }

    }
}
