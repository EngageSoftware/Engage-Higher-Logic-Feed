// <copyright file="ViewHigherLogicFeedPresenter.cs" company="Engage">
// Engage: Higher Logic Feed
// Copyright (c) 2016
// </copyright>
namespace Engage.Dnn.HigherLogicFeed
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    using DotNetNuke.Common.Utilities;
    using DotNetNuke.Entities.Host;
    using DotNetNuke.Security;
    using DotNetNuke.Services.Tokens;
    using DotNetNuke.Web.Mvp;

    using Engage.Dnn.HigherLogicFeed.HigherLogicFeed.Components;
    using Engage.Util;

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

        /// <summary>Gets the maximum length of the content.</summary>
        private int MaxContentLength =>
            HigherLogicFeedSettings.MaxContentLength.GetValueAsInt32For(
                FeaturesController.SettingsPrefix,
                this.ModuleContext.Configuration,
                HigherLogicFeedSettings.MaxContentLength.DefaultValue);

        /// <summary>Gets the maximum length of the subject.</summary>
        private int MaxSubjectLength =>
            HigherLogicFeedSettings.MaxSubjectLength.GetValueAsInt32For(
                FeaturesController.SettingsPrefix,
                this.ModuleContext.Configuration,
                HigherLogicFeedSettings.MaxSubjectLength.DefaultValue);

        /// <summary>Gets a value indicating whether or not to include stafff posts..</summary>
        private bool IncludeStaff => HigherLogicFeedSettings.IncludeStaff.GetValueAsBooleanFor(
            FeaturesController.SettingsPrefix,
            this.ModuleContext.Configuration,
            HigherLogicFeedSettings.IncludeStaff.DefaultValue);

        /// <summary>Gets a value indicating whether or not to include stafff posts..</summary>
        private string DateFormat => HigherLogicFeedSettings.DateFormat.GetValueAsStringFor(
            FeaturesController.SettingsPrefix,
            this.ModuleContext.Configuration,
            HigherLogicFeedSettings.DateFormat.DefaultValue);

        /// <summary>Gets the header template.</summary>
        private string HeaderTemplate =>
            HigherLogicFeedSettings.HeaderTemplate.GetValueAsStringFor(
                FeaturesController.SettingsPrefix,
                this.ModuleContext.Configuration,
                HigherLogicFeedSettings.HeaderTemplate.DefaultValue);

        /// <summary>Gets the item template.</summary>
        private string ItemTemplate =>
            HigherLogicFeedSettings.ItemTemplate.GetValueAsStringFor(
                FeaturesController.SettingsPrefix,
                this.ModuleContext.Configuration,
                HigherLogicFeedSettings.ItemTemplate.DefaultValue);

        /// <summary>Gets the footer template.</summary>
        private string FooterTemplate =>
            HigherLogicFeedSettings.FooterTemplate.GetValueAsStringFor(
                FeaturesController.SettingsPrefix,
                this.ModuleContext.Configuration,
                HigherLogicFeedSettings.FooterTemplate.DefaultValue);

        /// <summary>Gets the no records template.</summary>
        private string NoRecordsTemplate =>
            HigherLogicFeedSettings.NoRecordsTemplate.GetValueAsStringFor(
                FeaturesController.SettingsPrefix,
                this.ModuleContext.Configuration,
                HigherLogicFeedSettings.NoRecordsTemplate.DefaultValue);

        /// <summary>Gets the attachment item template.</summary>
        private string AttachmentItemTemplate =>
            HigherLogicFeedSettings.AttachmentItemTemplate.GetValueAsStringFor(
                FeaturesController.SettingsPrefix,
                this.ModuleContext.Configuration,
                HigherLogicFeedSettings.AttachmentItemTemplate.DefaultValue);

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

                var decryptedPassword = FIPSCompliant.DecryptAES(this.Password, Config.GetDecryptionkey(), Host.GUID, 1200);

                var authenticationToken = HigherLogicService.GetAuthenticationToken(this.Username, decryptedPassword, this.IAmKey);
                var postTask = HigherLogicService.GetDiscussionPosts(
                    this.DiscussionKey,
                    this.MaxDiscussionsToRetrieve,
                    this.MaxSubjectLength,
                    this.MaxContentLength,
                    this.IncludeStaff,
                    this.IAmKey,
                    authenticationToken);

                postTask.Wait();

                var discussionPosts = postTask.Result.ToArray();

                var tokenReplace = new TokenReplace();

                this.View.Model.FooterTemplate = tokenReplace.ReplaceEnvironmentTokens(
                    this.FooterTemplate,
                    new Dictionary<string, string>(),
                    "HL").AsRawHtml();

                this.View.Model.HeaderTemplate = tokenReplace.ReplaceEnvironmentTokens(
                    this.HeaderTemplate,
                    new Dictionary<string, string>(),
                    "HL").AsRawHtml();

                if (!discussionPosts.Any())
                {
                    this.View.Model.NoRecordsTemplate = tokenReplace.ReplaceEnvironmentTokens(
                        this.NoRecordsTemplate,
                        new Dictionary<string, string>(),
                        "HL").AsRawHtml();

                    return;
                }

                this.View.Model.HasRecords = true;
                var renderAttachemnts = this.ItemTemplate.Contains("[HL:Discussion:Attachments]");

                this.View.Model.ItemTemplate = (from post in discussionPosts
                                                 select tokenReplace.ReplaceEnvironmentTokens(
                                                    this.ItemTemplate,
                                                    this.BuildTokenDictionary(post, renderAttachemnts),
                                                    "HL"))
                                                .Aggregate((template, itemTemplate) => $"{template}{itemTemplate}")
                                                .AsRawHtml();
            }
            catch (AggregateException exc)
            {
                this.ProcessModuleLoadException(exc);
                this.View.Model.AdminMessage = exc.Message;
            }
        }

        /// <summary>Builds the custom token dictionary for a discussion post.</summary>
        /// <param name="post">The discussion post.</param>
        /// <param name="renderAttachemnts">if set to <c>true</c> [render attachemnts].</param>
        /// <returns>The custom token dictionary for a discussion post.</returns>
        private Dictionary<string, string> BuildTokenDictionary(DiscussionPost post, bool renderAttachemnts)
        {
            return new Dictionary<string, string>
                   {
                       { "Discussion:Body", post.Body },
                       { "Discussion:BodyWithoutMarkup", post.BodyWithoutMarkup.Substring(0, this.MaxContentLength > post.BodyWithoutMarkup.Length ? post.BodyWithoutMarkup.Length : this.MaxContentLength) },
                       { "Discussion:DiscussionName", post.DiscussionName },
                       { "Discussion:EmailAddress", post.EmailAddress },
                       { "Discussion:LinkToDiscussion", post.LinkToDiscussion },
                       { "Discussion:LinkToMessage", post.LinkToMessage },
                       { "Discussion:LinkToMessageInContext", post.LinkToMessageInContext },
                       { "Discussion:MessageStatus", post.MessageStatus },
                       { "Discussion:ModerationType", post.ModerationType },
                       { "Discussion:Subject", post.Subject.Substring(0, this.MaxContentLength > post.Subject.Length ? post.Subject.Length : this.MaxSubjectLength) },
                       { "Discussion:ContactKey", post.ContactKey.ToString() },
                       { "Discussion:DiscussionPostKey", post.DiscussionPostKey.ToString() },
                       { "Discussion:DiscussionKey", post.DiscussionKey.ToString() },
                       { "Discussion:DatePosted", post.DatePosted.ToString(this.DateFormat, CultureInfo.CurrentCulture) },
                       { "Discussion:Pinned", post.Pinned.ToString() },
                       { "Discussion:RecommendationCount", post.RecommendationCount.ToString() },
                       { "Discussion:Attachments", this.GetPostAttachmentMarkup(post.Attachments, renderAttachemnts) },
                       { "Author:LinkToProfile", post.Author.LinkToProfile },
                       { "Author:PictureUrl", post.Author.PictureUrl },
                       { "Author:ContactKey", post.Author.ContactKey.ToString() },
                       { "Author:FirstName", post.Author.FirstName },
                       { "Author:LastName", post.Author.LastName },
                       { "Author:DisplayName", post.Author.DisplayName },
                       { "Author:EmailAddress", post.Author.EmailAddress },
                       { "Author:CompanyName", post.Author.CompanyName },
                       { "Author:CompanyTitle", post.Author.CompanyTitle },
                       { "Author:Designation", post.Author.Designation },
                       { "Author:MiddleName", post.Author.MiddleName },
    };
        }

        /// <summary>Gets the post attachment markup.</summary>
        /// <param name="attachments">The attachments.</param>
        /// <param name="renderAttachemnts">if set to <c>true</c> [render attachemnts].</param>
        /// <returns>The HTML markup for a list of document attachments.</returns>
        private string GetPostAttachmentMarkup(IEnumerable<DocumentAttachment> attachments, bool renderAttachemnts)
        {
            if (!renderAttachemnts || !attachments.Any())
            {
                return string.Empty;
            }

            return attachments.Select(
                attachment =>
                new TokenReplace().ReplaceEnvironmentTokens(
                    this.AttachmentItemTemplate,
                    this.BuildAttachmentTokenDictionary(attachment),
                    "HL"))
                    .Aggregate((template, itemTemplate) => $"{template}{itemTemplate}");
        }

        /// <summary>Builds a custom token dictionary for a document attachment.</summary>
        /// <param name="attachment">The attachment.</param>
        /// <returns>The custom token dictinoary for a document attachment.</returns>
        private Dictionary<string, string> BuildAttachmentTokenDictionary(DocumentAttachment attachment)
        {
            return new Dictionary<string, string>
                   {
                       { "Attachment:DocumentAttachmentKey", attachment.DocumentAttachmentKey.ToString() },
                       { "Attachment:DocumentKey", attachment.DocumentKey.ToString() },
                       { "Attachment:FileName", attachment.FileName },
                       { "Attachment:UploadedByContact", attachment.UploadedByContact.ToString() },
                       { "Attachment:CreatedOn", attachment.CreatedOn.ToString(this.DateFormat, CultureInfo.CurrentCulture) },
                       { "Attachment:FileExtension", attachment.FileExtension },
                       { "Attachment:FileSizeInBytes", attachment.FileSizeInBytes.ToString() },
                       { "Attachment:Width", attachment.Width.ToString() },
                       { "Attachment:Height", attachment.Height.ToString() },
                       { "Attachment:DurationSeconds", attachment.DurationSeconds.ToString() },
                       { "Attachment:DownloadUrl", attachment.DownloadUrl },
                       { "Attachment:IconUrl", attachment.IconUrl },
                   };
        }
    }
}
