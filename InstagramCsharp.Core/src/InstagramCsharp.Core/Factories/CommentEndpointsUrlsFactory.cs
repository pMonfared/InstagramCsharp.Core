﻿using System;
using Microsoft.AspNetCore.WebUtilities;

namespace InstagramCSharp.Core.Factories
{
    public static class CommentEndpointsUrlsFactory
    {
        public static Uri CreateGETCommentsUrl(string mediaId, string accessToken)
        {
            var queryString = BuildCommentsEndpointsUrlQueryString(accessToken);
            return new Uri(InstagramAPIUrls.BaseAPIUrl + string.Format(InstagramAPIEndpoints.CommentsEndpoint, mediaId) + "?" + queryString); 
        }
        public static Uri CreatePOSTCommentUrl(string mediaId)
        {
            return new Uri(InstagramAPIUrls.BaseAPIUrl + string.Format(InstagramAPIEndpoints.CommentsEndpoint, mediaId));
        }
        public static Uri CreateDELETECommentUrl(string mediaId, string commentId, string accessToken)
        {
            var queryString = BuildCommentsEndpointsUrlQueryString(accessToken);
            return new Uri(InstagramAPIUrls.BaseAPIUrl + string.Format(InstagramAPIEndpoints.CommentEndpoint, mediaId, commentId) + "?" + queryString); 
        }
        private static string BuildCommentsEndpointsUrlQueryString(string accessToken)
        {
            var queryString = QueryHelpers.ParseQuery("");
            queryString["access_token"] = accessToken;
            return queryString.ToString();
        }       
    }
}
