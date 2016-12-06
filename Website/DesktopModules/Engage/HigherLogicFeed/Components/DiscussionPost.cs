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
        /// <summary>Gets or sets the author.</summary>
        /// <value>The author.</value>
        public ContactConcise Author { get; set; }

        /// <summary>Gets or sets the body.</summary>
        /// <value>The body.</value>
        public string Body { get; set; }

        /// <summary>Gets or sets the body without markup.</summary>
        /// <value>The body without markup.</value>
        public string BodyWithoutMarkup { get; set; }

        /// <summary>Gets or sets the contact key.</summary>
        /// <value>The contact key.</value>
        public Guid ContactKey { get; set; }

        /// <summary>Gets or sets the date posted.</summary>
        /// <value>The date posted.</value>
        public DateTime DatePosted { get; set; }

        /// <summary>Gets or sets the link to discussion.</summary>
        /// <value>The link to discussion.</value>
        public string LinkToDiscussion { get; set; }

        /// <summary>Gets or sets the link to message in context.</summary>
        /// <value>The link to message in context.</value>
        public string LinkToMessageInContext { get; set; }

        /// <summary>Gets or sets the name of the discussion.</summary>
        /// <value>The name of the discussion.</value>
        public string DiscussionName { get; set; }

        /// <summary>Gets or sets the email address.</summary>
        /// <value>The email address.</value>
        public string EmailAddress { get; set; }

        /// <summary>Gets or sets the link to message.</summary>
        /// <value>The link to message.</value>
        public string LinkToMessage { get; set; }

        /// <summary>Gets or sets the discussion post key.</summary>
        /// <value>The discussion post key.</value>
        public Guid DiscussionPostKey { get; set; }

        /// <summary>Gets or sets the discussion key.</summary>
        /// <value>The discussion key.</value>
        public Guid DiscussionKey { get; set; }

        /// <summary>Gets or sets the message status.</summary>
        /// <value>The message status.</value>
        public string MessageStatus { get; set; }

        /// <summary>Gets or sets the type of the moderation.</summary>
        /// <value>The type of the moderation.</value>
        public string ModerationType { get; set; }

        /// <summary>Gets or sets a value indicating whether this <see cref="DiscussionPost"/> is pinned.</summary>
        /// <value><c>true</c> if pinned; otherwise, <c>false</c>.</value>
        public bool Pinned { get; set; }

        /// <summary>Gets or sets the subject.</summary>
        /// <value>The subject.</value>
        public string Subject { get; set; }

        /// <summary>Gets or sets the recommendation count.</summary>
        /// <value>The recommendation count.</value>
        public int RecommendationCount { get; set; }

        /// <summary>Gets or sets the attachments.</summary>
        /// <value>The attachments.</value>
        public IEnumerable<DocumentAttachment> Attachments { get; set; }
    }
}