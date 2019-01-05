using Battler.NET.Models;
using Battler.NET.ParameterClasses;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;

namespace Battler.NET
{
    public class Battler
    {
        HttpClient httpClient = new HttpClient();

        public Battler(string apiKey)
        {
            httpClient.BaseAddress = new Uri("https://api.developer.battlerite.com/");
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.api+json"));
        }

        /// <summary>
        /// Get an array of matches without any filtering
        /// </summary>
        /// <returns></returns>
        public async Task<CompleteMatches> GetMatches()
        {
            var response = await httpClient.GetAsync("shards/global/matches");
            CompleteMatches matches = JsonConvert.DeserializeObject<CompleteMatches>(await response.Content.ReadAsStringAsync());
            return matches;
        }

        /// <summary>
        /// Get an array of matches with query parameters to filter the response
        /// </summary>
        /// <param name="parameters">Build with the MatchParameters class so you don't have to make sure if it's a valid query string!</param>
        /// <returns></returns>
        public async Task<CompleteMatches> GetMatches(MatchParameters parameters)
        {
            string queryparams = parameters.ToString();
            var response = await httpClient.GetAsync($"shards/global/matches/?{queryparams}");
            CompleteMatches matches = JsonConvert.DeserializeObject<CompleteMatches>(await response.Content.ReadAsStringAsync());
            return matches;
        }

        /// <summary>
        /// Get an array of matches with a self written query string
        /// </summary>
        /// <param name="queryString">A string of key value pairs "key=value"</param>
        /// <returns></returns>
        public async Task<CompleteMatches> GetMatches(string queryString)
        {
            var response = await httpClient.GetAsync($"shards/global/matches/?{queryString}");
            CompleteMatches matches = JsonConvert.DeserializeObject<CompleteMatches>(await response.Content.ReadAsStringAsync());
            return matches;
        }

        /// <summary>
        /// Get a single match by the match id
        /// </summary>
        /// <param name="id">ID of the match to get</param>
        /// <returns>Complete match info</returns>
        public async Task<CompleteMatch> GetMatch(string id)
        {
            var response = await httpClient.GetAsync($"shards/global/matches/{id}");
            CompleteMatch match = JsonConvert.DeserializeObject<CompleteMatch>(await response.Content.ReadAsStringAsync());
            return match;
        }
    }
}
