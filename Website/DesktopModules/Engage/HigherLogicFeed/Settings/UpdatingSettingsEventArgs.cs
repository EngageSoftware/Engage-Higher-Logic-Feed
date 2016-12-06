// <copyright file="UpdatingSettingsEventArgs.cs" company="Engage">
// Engage: Higher Logic Feed
// Copyright (c) 2016
// </copyright>
namespace Engage.Dnn.HigherLogicFeed
{
    using System;

    /// <summary>Contains data about the settings that have been updated by <see cref="ISettingsView"/></summary>
    public class UpdatingSettingsEventArgs : EventArgs
    {
        /// <summary>Initializes a new instance of the <see cref="UpdatingSettingsEventArgs" /> class.</summary>
        /// <param name="higherLogicUserName">Name of the higher logic user.</param>
        /// <param name="higherLogicPassword">The higher logic password.</param>
        /// <param name="higherLogicIAMKey">The higher logic iam key.</param>
        /// <param name="higherLogicDiscussionKey">The higher logic discussion key.</param>
        /// <param name="maxDiscussionsToRetrieve">The maximum discussions to retrieve.</param>
        /// <param name="includeStaff">if set to <c>true</c> [include staff].</param>
        /// <param name="dateFormat">The date format for the templates.</param>
        /// <param name="headerTemplate">The header display template.</param>
        /// <param name="itemTemplate">The item display template.</param>
        /// <param name="footerTemplate">The footer display template.</param>
        /// <param name="noRecordsTemplate">The no records template.</param>
        /// <param name="attachmentItemTemplate">The document attachment template.</param>
        /// <param name="maxContentLength">The maximum number of characters for the content.</param>
        /// <param name="maxSubjectLength">The maximum number of characters for the subject.</param>
        public UpdatingSettingsEventArgs(string higherLogicUserName, string higherLogicPassword, string higherLogicIAMKey, string higherLogicDiscussionKey, int maxDiscussionsToRetrieve, bool includeStaff, string dateFormat, string headerTemplate, string itemTemplate, string footerTemplate, string noRecordsTemplate, string attachmentItemTemplate, int maxContentLength, int maxSubjectLength)
        {
            this.HigherLogicUserName = higherLogicUserName;
            this.HigherLogicPassword = higherLogicPassword;
            this.HigherLogicIAMKey = higherLogicIAMKey;
            this.HigherLogicDiscussionKey = higherLogicDiscussionKey;
            this.MaxDiscussionsToRetrieve = maxDiscussionsToRetrieve;
            this.MaxContentLength = maxContentLength;
            this.MaxSubjectLength = maxSubjectLength;
            this.IncludeStaff = includeStaff;
            this.DateFormat = dateFormat;
            this.HeaderTemplate = headerTemplate;
            this.ItemTemplate = itemTemplate;
            this.FooterTemplate = footerTemplate;
            this.NoRecordsTemplate = noRecordsTemplate;
            this.AttachmentItemTemplate = attachmentItemTemplate;
        }

        /// <summary>Gets or sets the name of the higher logic acount username.</summary>
        /// <value>The name of the higher logic account username.</value>
        public string HigherLogicUserName { get; set; }

        /// <summary>Gets or sets the higher logic account password.</summary>
        /// <value>The higher logic account password.</value>
        public string HigherLogicPassword { get; set; }

        /// <summary>Gets or sets the higher logic IAMKey.</summary>
        /// <value>The higher logic IAMKey.</value>
        public string HigherLogicIAMKey { get; set; }

        /// <summary>Gets or sets the higher logic discussion key.</summary>
        /// <value>The higher logic discussion key.</value>
        public string HigherLogicDiscussionKey { get; set; }

        /// <summary>Gets or sets the maximum discussions to retrieve.</summary>
        /// <value>The maximum discussions to retrieve.</value>
        public int MaxDiscussionsToRetrieve { get; set; }

        /// <summary>Gets or sets the maximum length of the content.</summary>
        /// <value>The maximum length of the content.</value>
        public int MaxContentLength { get; set; }

        /// <summary>Gets or sets the maximum length of the subject.</summary>
        /// <value>The maximum length of the subject.</value>
        public int MaxSubjectLength { get; set; }

        /// <summary>Gets or sets a value indicating whether [include staff].</summary>
        /// <value><c>true</c> if [include staff]; otherwise, <c>false</c>.</value>
        public bool IncludeStaff { get; set; }

        /// <summary>Gets or sets the date format.</summary>
        /// <value>The date format.</value>
        public string DateFormat { get; set; }

        /// <summary>Gets or sets the header template.</summary>
        /// <value>The header template.</value>
        public string HeaderTemplate { get; set; }

        /// <summary>Gets or sets the item template.</summary>
        /// <value>The item template.</value>
        public string ItemTemplate { get; set; }

        /// <summary>Gets or sets the footer template.</summary>
        /// <value>The footer template.</value>
        public string FooterTemplate { get; set; }

        /// <summary>Gets or sets the no records template.</summary>
        /// <value>The no records template.</value>
        public string NoRecordsTemplate { get; set; }

        /// <summary>Gets or sets the attachment item template.</summary>
        /// <value>The attachment item template.</value>
        public string AttachmentItemTemplate { get; set; }
    }
}
