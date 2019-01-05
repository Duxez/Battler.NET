using System;
using System.Collections.Generic;
using System.Text;

namespace Battler.NET.ParameterClasses
{
    public class MatchParameters : Parameters
    {
        public MatchParameters(int? pageOffset = null, int? pageLimit = null, string sort = null, string filterCreatedAtStart = null, string filterCreatedAtEnd = null, string playerIds = null, float? filterPatchVersion = null, string serverType = null, string rankingType = null)
        {
            if (pageOffset != null)
                parameters.Add("pageOffset", pageOffset.ToString());

            if (pageLimit != null)
                parameters.Add("pageLimit", pageLimit.ToString());

            if (sort != null)
                parameters.Add("sort", sort.ToString());

            if (filterCreatedAtStart != null)
                parameters.Add("filterCreatedAtStart", filterCreatedAtStart.ToString());

            if (filterCreatedAtEnd != null)
                parameters.Add("filterCreatedAtEnd", filterCreatedAtEnd.ToString());

            if (playerIds != null)
                parameters.Add("playerIds", playerIds.ToString());

            if (filterPatchVersion != null)
                parameters.Add("filterPatchVersion", filterPatchVersion.ToString());

            if (serverType != null)
                parameters.Add("serverType", serverType.ToString());

            if (rankingType != null)
                parameters.Add("rankingType", rankingType.ToString());
        }
    }
}
