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

        /// <summary>Gets or sets the higher logic IAMKey.</summary>
        /// <value>The higher logic IAMKey.</value>
        public string HigherLogicIAMKey { get; set; }

        /// <summary>Gets or sets the higher logic discussion key.</summary>
        /// <value>The higher logic discussion key.</value>
        public string HigherLogicDiscussionKey { get; set; }

        /// <summary>Gets or sets the maximum discussions to retrieve.</summary>
        /// <value>The maximum discussions to retrieve.</value>
        public int MaxDiscussionsToRetrieve { get; set; }

        /// <summary>Gets or sets a value indicating whether [include staff].</summary>
        /// <value><c>true</c> if [include staff]; otherwise, <c>false</c>.</value>
        public bool IncludeStaff { get; set; }
    }
}
