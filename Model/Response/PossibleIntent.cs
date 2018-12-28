using Newtonsoft.Json;

namespace DisruptionWorks.Model.Response
{
    public class PossibleIntent
    {
        [JsonProperty("intent")]
        public string Intent { get; set; }
    }
}