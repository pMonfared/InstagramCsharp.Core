﻿using System;
using Microsoft.AspNetCore.WebUtilities;

namespace InstagramCSharp.Core.Factories
{
    public class LikeEndpointsUrlsFactory
    {
        public static Uri CreateGETLikeUrl(string mediaId, string accessToken)
        {
            var queryString = BuildLikeEndpointsUrlQueryString(accessToken);
            return new Uri(InstagramAPIUrls.BaseAPIUrl + string.Format(InstagramAPIEndpoints.LikesEndpoint, mediaId) + "?" + queryString);
        }
        public static Uri CreatePOSTLikeUrl(string mediaId)
        {
            return new Uri(InstagramAPIUrls.BaseAPIUrl + string.Format(InstagramAPIEndpoints.LikesEndpoint, mediaId)); 
        }
        public static Uri CreateDELETELikeUrl(string mediaId, string accessToken)
        {
            var queryString = BuildLikeEndpointsUrlQueryString(accessToken);
            return new Uri(InstagramAPIUrls.BaseAPIUrl + string.Format(InstagramAPIEndpoints.LikesEndpoint, mediaId) + "?" + queryString); 
        }
        private static string BuildLikeEndpointsUrlQueryString(string accessToken)
        {
            var queryString = QueryHelpers.ParseQuery("");
            queryString["access_token"] = accessToken;
            return queryString.ToString();
        }
    }
}
