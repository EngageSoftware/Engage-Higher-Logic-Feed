// <copyright file="InvalidResponse.cs" company="Engage">
// Engage: Higher Logic Feed
// Copyright (c) 2016
// </copyright>

namespace Engage.Dnn.HigherLogicFeed.HigherLogicFeed.Components
{
    using System;
    using System.Linq;

    /// <summary>The structure of an invalid response from the Higher Logic API.</summary>
    public class InvalidResponse
    {
        /// <summary>Gets or sets the message for the response..</summary>
        /// <value>The message.</value>
        public string Message { get; set; }

        /// <summary>Gets or sets the HTTP error code.</summary>
        /// <value>The HTTP error code.</value>
        public int ErrorCode { get; set; }
    }
}