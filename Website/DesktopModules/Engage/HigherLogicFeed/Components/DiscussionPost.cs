// <copyright file="DiscussionPost.cs" company="Engage">
// Engage: Higher Logic Feed
// Copyright (c) 2016
// </copyright>

namespace Engage.Dnn.HigherLogicFeed.HigherLogicFeed.Components
{
    using System;
    using System.Collections.Generic;

    /// <summary>Defines the structure of a discussion post from the Higher Logic API.</summary>
    public class DiscussionPost
    {
        public ContactConcise Author { get; set; }

        public string Body { get; set; }

        public string BodyWithoutMarkup { get; set; }

        public Guid ContactKey { get; set; }

        public DateTime DatePosted { get; set; }

        public string LinkToDiscussion { get; set; }

        public string LinkToMessageInContext { get; set; }

        public string DiscussionName { get; set; }

        public string EmailAddress { get; set; }

        public string LinkToMessage { get; set; }

        public Guid DiscussionPostKey { get; set; }

        public Guid DiscussionKey { get; set; }

        public string MessageStatus { get; set; }

        public string ModerationType { get; set; }

        public bool Pinned { get; set; }

        public string Subject { get; set; }

        public int RecommendationCount { get; set; }

        public IEnumerable<DocumentAttachment> Attachments { get; set; }
    }
}