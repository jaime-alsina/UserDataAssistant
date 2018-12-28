using Newtonsoft.Json;

namespace DisruptionWorks.Model.Response
{
    public class InputPrompt
    {
        [JsonProperty("richInitialPrompt")]
        public RichInitialPrompt RichInitialPrompt { get; set; }
    }
}