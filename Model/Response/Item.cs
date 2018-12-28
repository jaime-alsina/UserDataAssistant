using Newtonsoft.Json;

namespace Model.Response
{
    public class Item
    {
        [JsonProperty("simpleResponse")]
        public SimpleResponse SimpleResponse { get; set; }
    }
}