using System;
using System.Collections.Generic;
using System.Text;
using System.Web;

namespace Battler.NET.ParameterClasses
{
    public class Parameters
    {
        protected Dictionary<string, string> parameters = new Dictionary<string, string>();

        public override string ToString()
        {
            var query = HttpUtility.ParseQueryString(String.Empty);    
            foreach(var param in parameters)
            {
                if(param.Key.Contains("page"))
                {
                    string key = "page" + param.Key.Replace("page", "[") + "]";
                    query[key.ToLower()] = param.Value;
                }
                else if(param.Key.Contains("filter"))
                {
                    string key = "filter" + param.Key.Replace("filter", "[") + "]";
                    query[key.ToLower()] = param.Value;
                }
                else if(param.Key.Contains("tag"))
                {
                    string key = "tag" + param.Key.Replace("tag", "[") + "]";
                    query[key.ToLower()] = param.Value;
                }
                else
                {
                    query[param.Key.ToLower()] = param.Value;
                }
            }

            return query.ToString();
        }
    }
}
