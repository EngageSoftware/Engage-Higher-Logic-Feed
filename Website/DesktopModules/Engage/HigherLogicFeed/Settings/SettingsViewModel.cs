// <copyright file="SettingsViewModel.cs" company="Engage">
// Engage: Higher Logic Feed
// Copyright (c) 2016
// </copyright>
namespace Engage.Dnn.HigherLogicFeed
{
    /// <summary>The view model for the module's settings, to be displayed by <see cref="ISettingsView"/></summary>
    public class SettingsViewModel
    {
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
