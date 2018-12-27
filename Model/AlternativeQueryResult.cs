﻿using Newtonsoft.Json;

namespace Model
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