﻿using InstagramCSharp.Core.Enums;
using Microsoft.AspNetCore.WebUtilities;

namespace InstagramCSharp.Core.Factories
{
    public class RealTimeSubscriptionsUrlsFactory
    {
        public static string CreateGETAllSubscriptionsUrl(string clientId, string clientSecret)
        {
            var queryString = BuildGETAllSubscriptionsUrlQueryString(clientId, clientSecret);
            return BuildRealTimeSubscriptionUrl(InstagramAPIUrls.RealTimeSubscriptionsUrl, queryString);
        }

        private static object BuildGETAllSubscriptionsUrlQueryString(string clientId, string clientSecret)
        {
            var queryString = QueryHelpers.ParseQuery("");
            queryString["client_id"] = clientId;
            queryString["client_secret"] = clientSecret;
            return queryString.ToString();
        }
        public static string CreateDELETESubscriptionsUrl(string clientId, string clientSecret, long id)
        {
            var queryString = BuildDELETESubscriptionsUrlQueryString(clientId, clientSecret, id);
            return BuildRealTimeSubscriptionUrl(InstagramAPIUrls.RealTimeSubscriptionsUrl, queryString);
        }

        public static string CreateDELETESubscriptionsUrl(string clientId, string clientSecret, RealTimeObjects obj)
        {
            var queryString = BuildDELETESubscriptionsUrlQueryString(clientId, clientSecret, obj);
            return BuildRealTimeSubscriptionUrl(InstagramAPIUrls.RealTimeSubscriptionsUrl, queryString);
        }

        private static object BuildDELETESubscriptionsUrlQueryString(string clientId, string clientSecret, long id)
        {
            var queryString = QueryHelpers.ParseQuery("");
            queryString["client_id"] = clientId;
            queryString["client_secret"] = clientSecret;
            queryString["id"] = id.ToString();
            return queryString.ToString();
        }
        private static object BuildDELETESubscriptionsUrlQueryString(string clientId, string clientSecret, RealTimeObjects obj)
        {
            var queryString = QueryHelpers.ParseQuery("");
            queryString["client_id"] = clientId;
            queryString["client_secret"] = clientSecret;
            switch (obj)
            {
                case RealTimeObjects.User:
                    queryString["object"] = "user";
                    break;               
                case RealTimeObjects.All:
                    queryString["object"] = "all";
                    break;
                default:
                    break;
            }
            return queryString.ToString();
        }
        private static string BuildRealTimeSubscriptionUrl(string url, object queryString)
        {
            return url + "?" + queryString;
        }
    }
}
