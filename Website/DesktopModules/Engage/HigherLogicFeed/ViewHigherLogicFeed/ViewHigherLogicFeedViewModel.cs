// <copyright file="ViewHigherLogicFeedViewModel.cs" company="Engage">
// Engage: Higher Logic Feed
// Copyright (c) 2016
// </copyright>
namespace Engage.Dnn.HigherLogicFeed
{
    using System.Collections.Generic;

    using Engage.Dnn.HigherLogicFeed.HigherLogicFeed.Components;

    /// <summary>The view model for the Higher Logic Feed, to be displayed by <see cref="IViewHigherLogicFeedView"/></summary>
    public class ViewHigherLogicFeedViewModel
    {
        /// <summary>Gets or sets the admin message.</summary>
        /// <value>The admin message.</value>
        public string AdminMessage { get; set; }

        /// <summary>Gets or sets the list discussion posts.</summary>
        /// <value>The list discussion posts.</value>
        public IEnumerable<DiscussionPost> DiscussionPosts { get; set; }
    }
}
