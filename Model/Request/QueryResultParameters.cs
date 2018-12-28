using Newtonsoft.Json;

namespace Model.Request
{
    public class QueryResultParameters
    {
        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("given_name")]
        public string GivenName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("any")]
        public string Any { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}