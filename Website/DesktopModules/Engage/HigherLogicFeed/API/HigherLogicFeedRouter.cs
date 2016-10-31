// <copyright file="HigherLogicFeedRouter.cs" company="Engage">
// Engage: Higher Logic Feed
// Copyright (c) 2016
// </copyright>
namespace Engage.Dnn.HigherLogicFeed.API
{
    using DotNetNuke.Web.Api;

    /// <summary>Defines the routes for the web API</summary>
    public class HigherLogicFeedRouter : IServiceRouteMapper
    {
        /// <summary>Registers the route for the web service.</summary>
        /// <param name="mapRouteManager">The route manager.</param>
        public void RegisterRoutes(IMapRoute mapRouteManager)
        {
            mapRouteManager.MapHttpRoute(
                "Engage/HigherLogicFeed",
                "default",
                "{controller}/{action}",
                new[] { "Engage.Dnn.HigherLogicFeed.API", });
        }
    }
}
