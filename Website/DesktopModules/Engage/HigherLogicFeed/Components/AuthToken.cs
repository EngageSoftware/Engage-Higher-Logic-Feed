// <copyright file="AuthToken.cs" company="Engage">
// Engage: Higher Logic Feed
// Copyright (c) 2016
// </copyright>

namespace Engage.Dnn.HigherLogicFeed.HigherLogicFeed.Components
{
    using System;
    using System.Linq;

    /// <summary>Defines the response for the Authentication/Login API call to Higher Logic.</summary>
    public class AuthToken
    {
        /// <summary>Gets or sets the token.</summary>
        /// <value>The token.</value>
        public string Token { get; set; }
    }
}