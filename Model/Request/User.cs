using System;
using Newtonsoft.Json;

namespace Model.Request
{
    public class User
    {
        [JsonProperty("lastSeen")]
        public DateTimeOffset LastSeen { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }
    }
}