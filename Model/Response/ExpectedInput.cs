﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace DisruptionWorks.Model.Response
{
    public class ExpectedInput
    {
        [JsonProperty("inputPrompt")]
        public InputPrompt InputPrompt { get; set; }

        [JsonProperty("possibleIntents")]
        public List<PossibleIntent> PossibleIntents { get; set; }
    }
}