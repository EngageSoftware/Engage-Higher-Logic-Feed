// <copyright file="HigherLogicFeedController.cs" company="Engage">
// Engage: Higher Logic Feed
// Copyright (c) 2016
// </copyright>
namespace Engage.Dnn.HigherLogicFeed.API
{
    using System;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    using DotNetNuke.Security;
    using DotNetNuke.Services.Exceptions;
    using DotNetNuke.Web.Api;

    /// <summary>The web API for the module</summary>
    [DnnModuleAuthorize(AccessLevel = SecurityAccessLevel.View)]
    [SupportedModules("Engage: Higher Logic Feed")]
    public class HigherLogicFeedController : DnnApiController
    {
    }
}
