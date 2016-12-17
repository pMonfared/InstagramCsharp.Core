using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.WebUtilities;

namespace InstagramCSharp.Core
{
    internal static class Extensions
    {
        internal static Uri AddParameter(this Uri uri, string paramName, string paramValue)
        {
            var uriBuilder = new UriBuilder(uri);
            var query = QueryHelpers.ParseQuery(uriBuilder.Query);
            query[paramName] = paramValue;
            uriBuilder.Query = query.ToString();
            return new Uri(uriBuilder.ToString());
        }
    }
}
