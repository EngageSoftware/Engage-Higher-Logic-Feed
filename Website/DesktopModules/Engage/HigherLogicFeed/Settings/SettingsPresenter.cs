// <copyright file="SettingsPresenter.cs" company="Engage">
// Engage: Higher Logic Feed
// Copyright (c) 2016
// </copyright>
namespace Engage.Dnn.HigherLogicFeed
{
    using System;
    using System.Linq;

    using DotNetNuke.Common.Utilities;
    using DotNetNuke.Entities.Host;
    using DotNetNuke.Security;
    using DotNetNuke.Services.Localization;
    using DotNetNuke.Web.Mvp;

    using WebFormsMvp;

    /// <summary>Acts as a presenter for <see cref="ISettingsView"/></summary>
    public class SettingsPresenter : ModulePresenter<ISettingsView, SettingsViewModel>
    {
        /// <summary>Initializes a new instance of the <see cref="SettingsPresenter"/> class.</summary>
        /// <param name="view">The view.</param>
        public SettingsPresenter(ISettingsView view)
            : base(view)
        {
            this.View.Initialize += this.View_Initialize;
            this.View.UpdatingSettings += this.View_UpdatingSettings;
        }

        /// <summary>Handles the <see cref="IModuleViewBase.Initialize"/> event of the <see cref="Presenter{TView}.View"/> control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void View_Initialize(object sender, EventArgs e)
        {
            try
            {
                this.View.Model.HigherLogicUserName =
                    HigherLogicFeedSettings.HigherLogicUsername.GetValueAsStringFor(
                        FeaturesController.SettingsPrefix,
                        this.ModuleContext.Configuration,
                        HigherLogicFeedSettings.HigherLogicUsername.DefaultValue);

                var encryptedPassword =
                    HigherLogicFeedSettings.HigherLogicPassword.GetValueAsStringFor(
                        FeaturesController.SettingsPrefix,
                        this.ModuleContext.Configuration,
                        HigherLogicFeedSettings.HigherLogicPassword.DefaultValue);

                this.View.Model.HigherLogicPassword = FIPSCompliant.DecryptAES(encryptedPassword, Config.GetDecryptionkey(), Host.GUID, 1200);

                this.View.Model.HigherLogicIAMKey =
                    HigherLogicFeedSettings.HigherLogicIAMKey.GetValueAsStringFor(
                        FeaturesController.SettingsPrefix,
                        this.ModuleContext.Configuration,
                        HigherLogicFeedSettings.HigherLogicIAMKey.DefaultValue);

                this.View.Model.HigherLogicDiscussionKey =
                    HigherLogicFeedSettings.HigherLogicDiscussionKey.GetValueAsStringFor(
                        FeaturesController.SettingsPrefix,
                        this.ModuleContext.Configuration,
                        HigherLogicFeedSettings.HigherLogicDiscussionKey.DefaultValue);

                this.View.Model.MaxDiscussionsToRetrieve =
                    HigherLogicFeedSettings.MaxDiscussionsToRetrieve.GetValueAsInt32For(
                        FeaturesController.SettingsPrefix,
                        this.ModuleContext.Configuration,
                        HigherLogicFeedSettings.MaxDiscussionsToRetrieve.DefaultValue);

                this.View.Model.MaxContentLength =
                    HigherLogicFeedSettings.MaxContentLength.GetValueAsInt32For(
                        FeaturesController.SettingsPrefix,
                        this.ModuleContext.Configuration,
                        HigherLogicFeedSettings.MaxContentLength.DefaultValue);

                this.View.Model.MaxSubjectLength =
                    HigherLogicFeedSettings.MaxSubjectLength.GetValueAsInt32For(
                        FeaturesController.SettingsPrefix,
                        this.ModuleContext.Configuration,
                        HigherLogicFeedSettings.MaxSubjectLength.DefaultValue);

                this.View.Model.IncludeStaff =
                    HigherLogicFeedSettings.IncludeStaff.GetValueAsBooleanFor(
                        FeaturesController.SettingsPrefix,
                        this.ModuleContext.Configuration,
                        HigherLogicFeedSettings.IncludeStaff.DefaultValue);

                this.View.Model.DateFormat =
                    HigherLogicFeedSettings.DateFormat.GetValueAsStringFor(
                        FeaturesController.SettingsPrefix,
                        this.ModuleContext.Configuration,
                        HigherLogicFeedSettings.DateFormat.DefaultValue);

                if (string.IsNullOrEmpty(this.View.Model.HigherLogicUserName) || string.IsNullOrEmpty(this.View.Model.HigherLogicPassword) ||
                    string.IsNullOrEmpty(this.View.Model.HigherLogicIAMKey) || string.IsNullOrEmpty(this.View.Model.HigherLogicDiscussionKey))
                {
                    this.View.Model.HeaderTemplate = Localization.GetString("HeaderTemplate.Text", $"/DesktopModules/Engage/{Localization.LocalResourceDirectory}/{Localization.LocalSharedResourceFile}");
                    this.View.Model.ItemTemplate = Localization.GetString("ItemTemplate.Text", $"/DesktopModules/Engage/{Localization.LocalResourceDirectory}/{Localization.LocalSharedResourceFile}");
                    this.View.Model.FooterTemplate = Localization.GetString("FooterTemplate.Text", $"/DesktopModules/Engage/{Localization.LocalResourceDirectory}/{Localization.LocalSharedResourceFile}");
                    this.View.Model.NoRecordsTemplate = Localization.GetString("NoRecordsTemplate.Text", $"/DesktopModules/Engage/{Localization.LocalResourceDirectory}/{Localization.LocalSharedResourceFile}");
                    this.View.Model.AttachmentItemTemplate = Localization.GetString("AttachmentItemTemplate.Text", $"/DesktopModules/Engage/{Localization.LocalResourceDirectory}/{Localization.LocalSharedResourceFile}");

                    return;
                }

                this.View.Model.HeaderTemplate =
                    HigherLogicFeedSettings.HeaderTemplate.GetValueAsStringFor(
                        FeaturesController.SettingsPrefix,
                        this.ModuleContext.Configuration,
                        HigherLogicFeedSettings.HeaderTemplate.DefaultValue);

                this.View.Model.ItemTemplate =
                    HigherLogicFeedSettings.ItemTemplate.GetValueAsStringFor(
                        FeaturesController.SettingsPrefix,
                        this.ModuleContext.Configuration,
                        HigherLogicFeedSettings.ItemTemplate.DefaultValue);

                this.View.Model.FooterTemplate =
                    HigherLogicFeedSettings.FooterTemplate.GetValueAsStringFor(
                        FeaturesController.SettingsPrefix,
                        this.ModuleContext.Configuration,
                        HigherLogicFeedSettings.FooterTemplate.DefaultValue);

                this.View.Model.NoRecordsTemplate =
                    HigherLogicFeedSettings.NoRecordsTemplate.GetValueAsStringFor(
                        FeaturesController.SettingsPrefix,
                        this.ModuleContext.Configuration,
                        HigherLogicFeedSettings.NoRecordsTemplate.DefaultValue);

                this.View.Model.AttachmentItemTemplate =
                    HigherLogicFeedSettings.AttachmentItemTemplate.GetValueAsStringFor(
                        FeaturesController.SettingsPrefix,
                        this.ModuleContext.Configuration,
                        HigherLogicFeedSettings.AttachmentItemTemplate.DefaultValue);
            }
            catch (Exception exc)
            {
                this.ProcessModuleLoadException(exc);
            }
        }

        /// <summary>Handles the <see cref="ISettingsView.UpdatingSettings"/> event of the <see cref="Presenter{TView}.View"/> control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="UpdatingSettingsEventArgs"/> instance containing the event data.</param>
        private void View_UpdatingSettings(object sender, UpdatingSettingsEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(e.HigherLogicPassword))
                {
                    var encryptedPassword = FIPSCompliant.EncryptAES(e.HigherLogicPassword, Config.GetDecryptionkey(), Host.GUID, 1200);
                    HigherLogicFeedSettings.HigherLogicPassword.Set(FeaturesController.SettingsPrefix, this.ModuleContext.Configuration, encryptedPassword);
                }

                HigherLogicFeedSettings.HigherLogicUsername.Set(FeaturesController.SettingsPrefix, this.ModuleContext.Configuration, e.HigherLogicUserName);
                HigherLogicFeedSettings.HigherLogicIAMKey.Set(FeaturesController.SettingsPrefix, this.ModuleContext.Configuration, e.HigherLogicIAMKey);
                HigherLogicFeedSettings.HigherLogicDiscussionKey.Set(FeaturesController.SettingsPrefix, this.ModuleContext.Configuration, e.HigherLogicDiscussionKey);
                HigherLogicFeedSettings.MaxDiscussionsToRetrieve.Set(FeaturesController.SettingsPrefix, this.ModuleContext.Configuration, e.MaxDiscussionsToRetrieve < 0 ? 0 : e.MaxDiscussionsToRetrieve);
                HigherLogicFeedSettings.IncludeStaff.Set(FeaturesController.SettingsPrefix, this.ModuleContext.Configuration, e.IncludeStaff);
                HigherLogicFeedSettings.MaxContentLength.Set(FeaturesController.SettingsPrefix, this.ModuleContext.Configuration, e.MaxContentLength < 0 ? 0 : e.MaxContentLength);
                HigherLogicFeedSettings.MaxSubjectLength.Set(FeaturesController.SettingsPrefix, this.ModuleContext.Configuration, e.MaxSubjectLength < 0 ? 0 : e.MaxSubjectLength);
                HigherLogicFeedSettings.DateFormat.Set(FeaturesController.SettingsPrefix, this.ModuleContext.Configuration, e.DateFormat);
                HigherLogicFeedSettings.HeaderTemplate.Set(FeaturesController.SettingsPrefix, this.ModuleContext.Configuration, e.HeaderTemplate);
                HigherLogicFeedSettings.ItemTemplate.Set(FeaturesController.SettingsPrefix, this.ModuleContext.Configuration, e.ItemTemplate);
                HigherLogicFeedSettings.FooterTemplate.Set(FeaturesController.SettingsPrefix, this.ModuleContext.Configuration, e.FooterTemplate);
                HigherLogicFeedSettings.NoRecordsTemplate.Set(FeaturesController.SettingsPrefix, this.ModuleContext.Configuration, e.NoRecordsTemplate);
                HigherLogicFeedSettings.AttachmentItemTemplate.Set(FeaturesController.SettingsPrefix, this.ModuleContext.Configuration, e.AttachmentItemTemplate);
            }
            catch (Exception exc)
            {
                this.ProcessModuleLoadException(exc);
            }
        }
    }
}
