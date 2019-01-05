using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Battler.NET.Models
{
    public class MatchIncludes
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("attributes")]
        public IncludesAttributes Attributes { get; set; }

        [JsonProperty("relationships", NullValueHandling = NullValueHandling.Ignore)]
        public IncludesRelationships Relationships { get; set; }

        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public IncludesLinks Links { get; set; }
    }

    public class IncludesLinks
    {
        [JsonProperty("schema")]
        public string Schema { get; set; }

        [JsonProperty("self")]
        public Uri Self { get; set; }
    }

    public class IncludesRelationships
    {
        [JsonProperty("assets", NullValueHandling = NullValueHandling.Ignore)]
        public Assets Assets { get; set; }

        [JsonProperty("participants", NullValueHandling = NullValueHandling.Ignore)]
        public Assets Participants { get; set; }

        [JsonProperty("team", NullValueHandling = NullValueHandling.Ignore)]
        public Player Team { get; set; }

        [JsonProperty("player", NullValueHandling = NullValueHandling.Ignore)]
        public Player Player { get; set; }
    }

    public class Player
    {
        [JsonProperty("data")]
        public Data Data { get; set; }
    }

    public class IncludesAttributes
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("shardId", NullValueHandling = NullValueHandling.Ignore)]
        public string ShardId { get; set; }

        [JsonProperty("stats")]
        public Stats Stats { get; set; }

        [JsonProperty("titleId", NullValueHandling = NullValueHandling.Ignore)]
        public string TitleId { get; set; }

        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public long? Duration { get; set; }

        [JsonProperty("ordinal", NullValueHandling = NullValueHandling.Ignore)]
        public long? Ordinal { get; set; }

        [JsonProperty("won", NullValueHandling = NullValueHandling.Ignore)]
        public string Won { get; set; }

        [JsonProperty("patchVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string PatchVersion { get; set; }

        [JsonProperty("actor", NullValueHandling = NullValueHandling.Ignore)]
        public long? Actor { get; set; }

        [JsonProperty("URL", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Url { get; set; }

        [JsonProperty("createdAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreatedAt { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }
    }

    public class IncludesStats
    {
        [JsonProperty("winningTeam", NullValueHandling = NullValueHandling.Ignore)]
        public long? WinningTeam { get; set; }

        [JsonProperty("division", NullValueHandling = NullValueHandling.Ignore)]
        public long? Division { get; set; }

        [JsonProperty("divisionRating", NullValueHandling = NullValueHandling.Ignore)]
        public long? DivisionRating { get; set; }

        [JsonProperty("league", NullValueHandling = NullValueHandling.Ignore)]
        public long? League { get; set; }

        [JsonProperty("losses", NullValueHandling = NullValueHandling.Ignore)]
        public long? Losses { get; set; }

        [JsonProperty("matchRegion", NullValueHandling = NullValueHandling.Ignore)]
        public string MatchRegion { get; set; }

        [JsonProperty("placementGamesLeft", NullValueHandling = NullValueHandling.Ignore)]
        public long? PlacementGamesLeft { get; set; }

        [JsonProperty("prevDivision", NullValueHandling = NullValueHandling.Ignore)]
        public long? PrevDivision { get; set; }

        [JsonProperty("prevDivisionRating", NullValueHandling = NullValueHandling.Ignore)]
        public long? PrevDivisionRating { get; set; }

        [JsonProperty("prevLeague", NullValueHandling = NullValueHandling.Ignore)]
        public long? PrevLeague { get; set; }

        [JsonProperty("prevLosses", NullValueHandling = NullValueHandling.Ignore)]
        public long? PrevLosses { get; set; }

        [JsonProperty("prevPlacementGamesLeft", NullValueHandling = NullValueHandling.Ignore)]
        public long? PrevPlacementGamesLeft { get; set; }

        [JsonProperty("prevWins", NullValueHandling = NullValueHandling.Ignore)]
        public long? PrevWins { get; set; }

        [JsonProperty("rankingChangeType", NullValueHandling = NullValueHandling.Ignore)]
        public string RankingChangeType { get; set; }

        [JsonProperty("roundsLost", NullValueHandling = NullValueHandling.Ignore)]
        public long? RoundsLost { get; set; }

        [JsonProperty("roundsWon", NullValueHandling = NullValueHandling.Ignore)]
        public long? RoundsWon { get; set; }

        [JsonProperty("score", NullValueHandling = NullValueHandling.Ignore)]
        public long? Score { get; set; }

        [JsonProperty("season", NullValueHandling = NullValueHandling.Ignore)]
        public long? Season { get; set; }

        [JsonProperty("teamSize", NullValueHandling = NullValueHandling.Ignore)]
        public long? TeamSize { get; set; }

        [JsonProperty("wins", NullValueHandling = NullValueHandling.Ignore)]
        public long? Wins { get; set; }

        [JsonProperty("abilityUses", NullValueHandling = NullValueHandling.Ignore)]
        public long? AbilityUses { get; set; }

        [JsonProperty("attachment", NullValueHandling = NullValueHandling.Ignore)]
        public long? Attachment { get; set; }

        [JsonProperty("damageDone", NullValueHandling = NullValueHandling.Ignore)]
        public long? DamageDone { get; set; }

        [JsonProperty("damageReceived", NullValueHandling = NullValueHandling.Ignore)]
        public long? DamageReceived { get; set; }

        [JsonProperty("deaths", NullValueHandling = NullValueHandling.Ignore)]
        public long? Deaths { get; set; }

        [JsonProperty("disablesDone", NullValueHandling = NullValueHandling.Ignore)]
        public long? DisablesDone { get; set; }

        [JsonProperty("disablesReceived", NullValueHandling = NullValueHandling.Ignore)]
        public long? DisablesReceived { get; set; }

        [JsonProperty("emote", NullValueHandling = NullValueHandling.Ignore)]
        public long? Emote { get; set; }

        [JsonProperty("energyGained", NullValueHandling = NullValueHandling.Ignore)]
        public long? EnergyGained { get; set; }

        [JsonProperty("energyUsed", NullValueHandling = NullValueHandling.Ignore)]
        public long? EnergyUsed { get; set; }

        [JsonProperty("healingDone", NullValueHandling = NullValueHandling.Ignore)]
        public long? HealingDone { get; set; }

        [JsonProperty("healingReceived", NullValueHandling = NullValueHandling.Ignore)]
        public long? HealingReceived { get; set; }

        [JsonProperty("kills", NullValueHandling = NullValueHandling.Ignore)]
        public long? Kills { get; set; }

        [JsonProperty("mount", NullValueHandling = NullValueHandling.Ignore)]
        public long? Mount { get; set; }

        [JsonProperty("outfit", NullValueHandling = NullValueHandling.Ignore)]
        public long? Outfit { get; set; }

        [JsonProperty("side", NullValueHandling = NullValueHandling.Ignore)]
        public long? Side { get; set; }

        [JsonProperty("timeAlive", NullValueHandling = NullValueHandling.Ignore)]
        public long? TimeAlive { get; set; }
    }
}
