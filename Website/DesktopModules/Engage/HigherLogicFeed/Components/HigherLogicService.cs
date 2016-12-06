// <copyright file="HigherLogicService.cs" company="Engage">
// Engage: Higher Logic Feed
// Copyright (c) 2016
// </copyright>

namespace Engage.Dnn.HigherLogicFeed.HigherLogicFeed.Components
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;
    using System.Web.Caching;

    using DotNetNuke.Common.Utilities;

    /// <summary>Service that connects to the Higher Logic API.</summary>
    public static class HigherLogicService
    {
        /// <summary>Gets the Higher Logic authentication token.</summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <param name="iamkey">The iamkey.</param>
        /// <returns>An authentication token from the Higher Logic API.</returns>
        public static string GetAuthenticationToken(string username, string password, string iamkey)
        {
            return DataCache.GetCachedData<string>(
                new CacheItemArgs($"{FeaturesController.CachePrefix}_Authenticate_{iamkey}", 20, CacheItemPriority.Normal, username, password, iamkey),
                GetAuthenticationToken);
        }

        /// <summary>Authenticates the specified username.</summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <param name="iamkey">The iamkey.</param>
        /// <returns>A task to get an authentication token from the Higher Logic API.</returns>
        public static async Task<AuthToken> Authenticate(string username, string password, string iamkey)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(FeaturesController.HigherLogicApiPrefix);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("HLIAMKey", iamkey);
                var response = await client.PostAsJsonAsync("Authentication/Login", new { Username = username, Password = password });

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<AuthToken>();
                }

                var invalidResponse = await response.Content.ReadAsAsync<InvalidResponse>();
                throw new Exception(invalidResponse.Message);
            }
        }

        /// <summary>Gets the discussion posts.</summary>
        /// <param name="discussionKey">The discussion key.</param>
        /// <param name="maxNumberToRetrieve">The maximum number to retrieve.</param>
        /// <param name="maxSubjectLength">Maximum length of the subject.</param>
        /// <param name="maxContentLength">Maximum length of the content.</param>
        /// <param name="includeStaff">if set to <c>true</c> [include staff].</param>
        /// <param name="iamkey">The iamkey.</param>
        /// <param name="authToken">The authentication token.</param>
        /// <returns>A list of disucssion posts for the authenticated user.</returns>
        public static async Task<IEnumerable<DiscussionPost>> GetDiscussionPosts(
            string discussionKey,
            int maxNumberToRetrieve,
            int maxSubjectLength,
            int maxContentLength,
            bool includeStaff,
            string iamkey,
            string authToken)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(FeaturesController.HigherLogicApiPrefix);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("HLIAMKey", iamkey);
                client.DefaultRequestHeaders.Add("HLAuthToken", authToken);

                var response = await client.GetAsync($"Discussions/GetDiscussionPosts?discussionKey={discussionKey}&maxToRetrieve={maxNumberToRetrieve}&includeStaff={includeStaff}");

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<IEnumerable<DiscussionPost>>();
                }

                var invalidResponse = await response.Content.ReadAsAsync<InvalidResponse>();
                throw new Exception(invalidResponse.Message);
            }
        }

        /// <summary>Gets the Higher Logic authentication token.</summary>
        /// <param name="args">the cache arguments containing username, password, and iamKey.</param>
        /// <returns>An authentication token from the Higher Logic API.</returns>
        private static string GetAuthenticationToken(CacheItemArgs args)
        {
            var username = (string)args.Params[0];
            var password = (string)args.Params[1];
            var iamKey = (string)args.Params[2];

            var tokenTask = Authenticate(username, password, iamKey);

            tokenTask.Wait();

            return tokenTask.Result.Token;
        }
    }
}