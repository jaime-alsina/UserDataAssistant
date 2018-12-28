using Newtonsoft.Json;

namespace Model.Response
{
    public class PossibleIntent
    {
        [JsonProperty("intent")]
        public string Intent { get; set; }
    }
}