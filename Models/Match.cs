using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Battler.NET.Models
{
    public class Match
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("attributes")]
        public Attributes Attributes { get; set; }

        [JsonProperty("relationships")]
        public Relationships Relationships { get; set; }

        [JsonProperty("links")]
        public Links Links { get; set; }
    }

    public class Attributes
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }
        [JsonProperty("duration")]
        public int Duration { get; set; }
        [JsonProperty("gameMode")]
        public string GameMode { get; set; }
        [JsonProperty("patchVersion")]
        public string PatchVersion { get; set; }
        [JsonProperty("shardId")]
        public string ShardId { get; set; }
        [JsonProperty("stats")]
        public Stats Stats { get; set; }
        [JsonProperty("tags")]
        public Tags Tags { get; set; }
        [JsonProperty("titleId")]
        public string TitleId { get; set; }
    }

    public class Stats
    {
        [JsonProperty("mapID")]
        public string MapID { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class Tags
    {
        [JsonProperty("rankingType")]
        public string RankingType { get; set; }
        [JsonProperty("serverType")]
        public string ServerType { get; set; }
    }

    public class Relationships
    {
        [JsonProperty("assets")]
        public Assets Assets { get; set; }
        [JsonProperty("rosters")]
        public Assets Rosters { get; set; }
        [JsonProperty("rounds")]
        public Assets Rounds { get; set; }
        [JsonProperty("spectators")]
        public Assets Spectators { get; set; }
    }

    public class Assets
    {
        [JsonProperty("data")]
        public Data[] Data;
    }

    public class Data
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
    }
    
    public class Links
    {
        [JsonProperty("schema")]
        public string Schema { get; set; }
        [JsonProperty("self")]
        public string Self { get; set; }
    }
}
