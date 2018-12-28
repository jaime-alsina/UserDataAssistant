using Newtonsoft.Json;

namespace DisruptionWorks.Model.Response
{
    public class Item
    {
        [JsonProperty("simpleResponse")]
        public SimpleResponse SimpleResponse { get; set; }
    }
}