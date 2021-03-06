﻿using Newtonsoft.Json;

namespace DisruptionWorks.Model.Request
{
    public class OutputContext
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parameters")]
        public OutputContextParameters Parameters { get; set; }

        [JsonProperty("lifespanCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? LifespanCount { get; set; }
    }
}