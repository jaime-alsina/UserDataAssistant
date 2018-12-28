using Newtonsoft.Json;

namespace DisruptionWorks.Model.Request
{
    public class AlternativeQueryResult
    {
        [JsonProperty("queryText")]
        public string QueryText { get; set; }

        [JsonProperty("outputContexts")]
        public OutputContext[] OutputContexts { get; set; }

        [JsonProperty("languageCode")]
        public string LanguageCode { get; set; }
    }
}