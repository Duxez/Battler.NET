using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Battler.NET.Models
{
    public class CompleteMatch
    {
        [JsonProperty("data")]
        public Match match { get; set; }
        [JsonProperty("included")]
        public MatchIncludes[] matchIncludes { get; set; }
    }

    public class CompleteMatches
    {
        [JsonProperty("data")]
        public Match[] match { get; set; }
        [JsonProperty("included")]
        public MatchIncludes[] matchIncludes { get; set; }
    }
}
