using Newtonsoft.Json;

namespace Model.Request
{
    public class OutputContextParameters
    {
        [JsonProperty("url.original")]
        public string UrlOriginal { get; set; }

        [JsonProperty("email.original")]
        public string EmailOriginal { get; set; }

        [JsonProperty("given_name.original")]
        public string GivenNameOriginal { get; set; }

        [JsonProperty("last_name.original")]
        public string LastNameOriginal { get; set; }

        [JsonProperty("phone_number.original")]
        public string PhoneNumberOriginal { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("any.original")]
        public string AnyOriginal { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("given_name")]
        public string GivenName { get; set; }

        [JsonProperty("any")]
        public string Any { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}