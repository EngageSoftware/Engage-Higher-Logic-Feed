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
        public UpdatingSettingsEventArgs(string higherLogicUserName, string higherLogicPassword, string higherLogicIAMKey, string higherLogicDiscussionKey, int maxDiscussionsToRetrieve, bool includeStaff)
        {
            this.HigherLogicUserName = higherLogicUserName;
            this.HigherLogicPassword = higherLogicPassword;
            this.HigherLogicIAMKey = higherLogicIAMKey;
            this.HigherLogicDiscussionKey = higherLogicDiscussionKey;
            this.MaxDiscussionsToRetrieve = maxDiscussionsToRetrieve;
            this.IncludeStaff = includeStaff;
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

        /// <summary>Gets or sets a value indicating whether [include staff].</summary>
        /// <value><c>true</c> if [include staff]; otherwise, <c>false</c>.</value>
        public bool IncludeStaff { get; set; }
    }
}
