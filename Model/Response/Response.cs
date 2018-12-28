using System.Collections.Generic;
using Newtonsoft.Json;

namespace Model.Response
{
    public class Response
    {
        [JsonProperty("simpleResponse")]
        public SimpleResponse SimpleResponse { get; set; }

        //[JsonProperty("conversationToken")]
        //public string ConversationToken { get; set; }

        //[JsonProperty("expectUserResponse")]
        //public bool ExpectUserResponse { get; set; }

        //[JsonProperty("expectedInputs")]
        //public List<ExpectedInput> ExpectedInputs { get; set; }
    }
}