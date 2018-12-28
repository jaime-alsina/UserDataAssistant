using Newtonsoft.Json;

namespace Model.Response
{
    public class InputPrompt
    {
        [JsonProperty("richInitialPrompt")]
        public RichInitialPrompt RichInitialPrompt { get; set; }
    }
}