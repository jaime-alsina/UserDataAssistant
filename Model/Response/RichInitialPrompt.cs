using System.Collections.Generic;
using Newtonsoft.Json;

namespace DisruptionWorks.Model.Response
{
    public class RichInitialPrompt
    {
        [JsonProperty("items")]
        public List<Item> Items { get; set; }

        [JsonProperty("suggestions")]
        public List<object> Suggestions { get; set; }
    }
}