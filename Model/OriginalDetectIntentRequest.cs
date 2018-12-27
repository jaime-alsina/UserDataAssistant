﻿using Newtonsoft.Json;

namespace Model
{
    public class OriginalDetectIntentRequest
    {
        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("version")]
        public long Version { get; set; }

        [JsonProperty("payload")]
        public Payload Payload { get; set; }
    }
}