using System;
using Newtonsoft.Json;

namespace Model
{
    public class AssistantRequest
    {
        [JsonProperty("responseId")]
        public Guid ResponseId { get; set; }

        [JsonProperty("queryResult")]
        public QueryResult QueryResult { get; set; }

        [JsonProperty("originalDetectIntentRequest")]
        public OriginalDetectIntentRequest OriginalDetectIntentRequest { get; set; }

        [JsonProperty("session")] public string Session { get; set; }

        [JsonProperty("alternativeQueryResults")]
        public AlternativeQueryResult[] AlternativeQueryResults { get; set; }
    }
}