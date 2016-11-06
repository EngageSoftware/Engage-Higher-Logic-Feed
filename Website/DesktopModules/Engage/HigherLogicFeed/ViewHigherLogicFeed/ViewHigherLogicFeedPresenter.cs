// <copyright file="ViewHigherLogicFeedPresenter.cs" company="Engage">
// Engage: Higher Logic Feed
// Copyright (c) 2016
// </copyright>
namespace Engage.Dnn.HigherLogicFeed
{
    using System;
    using System.Globalization;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Net.Mime;

    using DotNetNuke.Common.Utilities;
    using DotNetNuke.Entities.Host;
    using DotNetNuke.Security;
    using DotNetNuke.Services.Localization;
    using DotNetNuke.Web.Mvp;

    using Engage.Dnn.HigherLogicFeed.HigherLogicFeed.Components;

    using WebFormsMvp;

    /// <summary>Acts as a presenter for <see cref="IViewHigherLogicFeedView"/></summary>
    public sealed class ViewHigherLogicFeedPresenter : ModulePresenter<IViewHigherLogicFeedView, ViewHigherLogicFeedViewModel>
    {
        /// <summary>Initializes a new instance of the <see cref="ViewHigherLogicFeedPresenter"/> class.</summary>
        /// <param name="view">The view.</param>
        public ViewHigherLogicFeedPresenter(IViewHigherLogicFeedView view)
            : base(view)
        {
            this.View.Initialize += this.View_Initialize;
        }

        /// <summary>Gets the username from the settings.</summary>
        private string Username => HigherLogicFeedSettings.HigherLogicUsername.GetValueAsStringFor(
            FeaturesController.SettingsPrefix,
            this.ModuleContext.Configuration,
            HigherLogicFeedSettings.HigherLogicUsername.DefaultValue);

        /// <summary>Gets the password from the settings.</summary>
        private string Password => HigherLogicFeedSettings.HigherLogicPassword.GetValueAsStringFor(
            FeaturesController.SettingsPrefix,
            this.ModuleContext.Configuration,
            HigherLogicFeedSettings.HigherLogicPassword.DefaultValue);

        /// <summary>Gets the iamKey from the settings.</summary>
        private string IAmKey => HigherLogicFeedSettings.HigherLogicIAMKey.GetValueAsStringFor(
            FeaturesController.SettingsPrefix,
            this.ModuleContext.Configuration,
            HigherLogicFeedSettings.HigherLogicIAMKey.DefaultValue);

        /// <summary>Gets the discussion key from the settings.</summary>
        private string DiscussionKey => HigherLogicFeedSettings.HigherLogicDiscussionKey.GetValueAsStringFor(
            FeaturesController.SettingsPrefix,
            this.ModuleContext.Configuration,
            HigherLogicFeedSettings.HigherLogicDiscussionKey.DefaultValue);

        /// <summary>Gets the maximum number of discussion posts to retrieve from the settings.</summary>
        private int MaxDiscussionsToRetrieve => HigherLogicFeedSettings.MaxDiscussionsToRetrieve.GetValueAsInt32For(
            FeaturesController.SettingsPrefix,
            this.ModuleContext.Configuration,
            HigherLogicFeedSettings.MaxDiscussionsToRetrieve.DefaultValue);

        /// <summary>Gets a value indicating whether or not to include stafff posts..</summary>
        private bool IncludeStaff => HigherLogicFeedSettings.IncludeStaff.GetValueAsBooleanFor(
            FeaturesController.SettingsPrefix,
            this.ModuleContext.Configuration,
            HigherLogicFeedSettings.IncludeStaff.DefaultValue);

        /// <summary>Handles the <see cref="IModuleViewBase.Initialize"/> event of the <see cref="Presenter{TView}.View"/>.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void View_Initialize(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.Username) || string.IsNullOrEmpty(this.Password) || string.IsNullOrEmpty(this.IAmKey)
                    || string.IsNullOrEmpty(this.DiscussionKey))
                {
                    this.View.Model.AdminMessage = this.LocalizeString("ModuleNeedsToBeConfigured.Text");
                    return;
                }

                var decryptedPassword = FIPSCompliant.DecryptAES(this.Password, Config.GetDecryptionkey(), Host.GUID);

                var authenticationToken = HigherLogicService.GetAuthenticationToken(this.Username, decryptedPassword, this.IAmKey);
                var postTask = HigherLogicService.GetDiscussionPosts(
                    this.DiscussionKey,
                    this.MaxDiscussionsToRetrieve,
                    this.IncludeStaff,
                    this.IAmKey,
                    authenticationToken);

                postTask.Wait();

                this.View.Model.DiscussionPosts = postTask.Result;
            }
            catch (AggregateException exc)
            {
                this.ProcessModuleLoadException(exc);
                this.View.Model.AdminMessage = exc.Message;
            }
        }
    }
}
