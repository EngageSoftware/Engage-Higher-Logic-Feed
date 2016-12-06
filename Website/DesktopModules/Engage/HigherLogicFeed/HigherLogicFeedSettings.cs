// <copyright file="HigherLogicFeedSettings.cs" company="Engage">
// Engage: Higher Logic Feed
// Copyright (c) 2016
// </copyright>
namespace Engage.Dnn.HigherLogicFeed
{
    using System.Diagnostics.CodeAnalysis;

    using Engage.Dnn.Framework;

    /// <summary>A collection of the <see cref="Setting{T}"/>s for this module</summary>
    public static class HigherLogicFeedSettings
    {
        /// <summary>The username used to communicate with the higher logic api.</summary>
        [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Justification = "Setting<T> is immutable")]
        public static readonly Setting<string> HigherLogicUsername = new Setting<string>("HigherLogicUsername", SettingScope.TabModule, string.Empty);

        /// <summary>The password used to communicate with the higher logic api.</summary>
        [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Justification = "Setting<T> is immutable")]
        public static readonly Setting<string> HigherLogicPassword = new Setting<string>("HigherLogicPassword", SettingScope.TabModule, string.Empty);

        /// <summary>The IAMKey for the organization used to communicate with the higher logic api.</summary>
        [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Justification = "Setting<T> is immutable")]
        public static readonly Setting<string> HigherLogicIAMKey = new Setting<string>("HigherLogicIAMKey", SettingScope.TabModule, string.Empty);

        /// <summary>The discussion key used to communicate with the higher logic api to retrieve discussion posts.</summary>
        [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Justification = "Setting<T> is immutable")]
        public static readonly Setting<string> HigherLogicDiscussionKey = new Setting<string>("HigherLogicDiscussionKey", SettingScope.TabModule, string.Empty);

        /// <summary>Defines the maximum number of discussion posts to retrieve from the higher logic api.</summary>
        [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Justification = "Setting<T> is immutable")]
        public static readonly Setting<int> MaxDiscussionsToRetrieve = new Setting<int>("MaxDiscussionsToRetrieve", SettingScope.TabModule, 5);

        /// <summary><c>True</c> if the retrieved discussion posts should include staff posts; otherwise, <c>False</c>.</summary>
        [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Justification = "Setting<T> is immutable")]
        public static readonly Setting<bool> IncludeStaff = new Setting<bool>("IncludeStaff", SettingScope.TabModule, false);

        /// <summary>Defines the maximum length for the content of a discussion post.</summary>
        [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Justification = "Setting<T> is immutable")]
        public static readonly Setting<int> MaxContentLength = new Setting<int>("MaxContentLength", SettingScope.TabModule, 100);

        /// <summary>Defines the maximum length for the subject of a dicussion post.</summary>
        [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Justification = "Setting<T> is immutable")]
        public static readonly Setting<int> MaxSubjectLength = new Setting<int>("MaxSubjectLength", SettingScope.TabModule, 100);

        /// <summary>Defines whether or not to cache the discussion posts.</summary>
        [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Justification = "Setting<T> is immutable")]
        public static readonly Setting<bool> CacheDiscussionPosts = new Setting<bool>("CacheDiscussionPosts", SettingScope.TabModule, false);

        /// <summary>Defines the header template for the feed.</summary>
        [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Justification = "Setting<T> is immutable")]
        public static readonly Setting<string> HeaderTemplate = new Setting<string>("HeaderTemplate", SettingScope.TabModule, string.Empty);

        /// <summary>Defines the footer template for the feed.</summary>
        [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Justification = "Setting<T> is immutable")]
        public static readonly Setting<string> FooterTemplate = new Setting<string>("FooterTemplate", SettingScope.TabModule, string.Empty);

        /// <summary>Defines the item template for the feed.</summary>
        [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Justification = "Setting<T> is immutable")]
        public static readonly Setting<string> ItemTemplate = new Setting<string>("ItemTemplate", SettingScope.TabModule, string.Empty);

        /// <summary>Defines the no records template for the feed.</summary>
        [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Justification = "Setting<T> is immutable")]
        public static readonly Setting<string> NoRecordsTemplate = new Setting<string>("NoRecordsTemplate", SettingScope.TabModule, string.Empty);

        /// <summary>Defines the attachment template for the feed.</summary>
        [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Justification = "Setting<T> is immutable")]
        public static readonly Setting<string> AttachmentItemTemplate = new Setting<string>("AttachmentItemTemplate", SettingScope.TabModule, string.Empty);

        /// <summary>Defines the date format for the higher logic feed.</summary>
        [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Justification = "Setting<T> is immutable")]
        public static readonly Setting<string> DateFormat = new Setting<string>("DateFormat", SettingScope.TabModule, "MM/dd/yyyy");
    }
}
