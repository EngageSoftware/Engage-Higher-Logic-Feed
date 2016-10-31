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

                this.View.Model.IncludeStaff =
                    HigherLogicFeedSettings.IncludeStaff.GetValueAsBooleanFor(
                        FeaturesController.SettingsPrefix,
                        this.ModuleContext.Configuration,
                        HigherLogicFeedSettings.IncludeStaff.DefaultValue);

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
                    var encryptedPassword = FIPSCompliant.EncryptAES(e.HigherLogicPassword, Config.GetDecryptionkey(), Host.GUID);
                    HigherLogicFeedSettings.HigherLogicPassword.Set(FeaturesController.SettingsPrefix, this.ModuleContext.Configuration, encryptedPassword);
                }

                HigherLogicFeedSettings.HigherLogicUsername.Set(FeaturesController.SettingsPrefix, this.ModuleContext.Configuration, e.HigherLogicUserName);
                HigherLogicFeedSettings.HigherLogicIAMKey.Set(FeaturesController.SettingsPrefix, this.ModuleContext.Configuration, e.HigherLogicIAMKey);
                HigherLogicFeedSettings.HigherLogicDiscussionKey.Set(FeaturesController.SettingsPrefix, this.ModuleContext.Configuration, e.HigherLogicDiscussionKey);
                HigherLogicFeedSettings.MaxDiscussionsToRetrieve.Set(FeaturesController.SettingsPrefix, this.ModuleContext.Configuration, e.MaxDiscussionsToRetrieve);
                HigherLogicFeedSettings.IncludeStaff.Set(FeaturesController.SettingsPrefix, this.ModuleContext.Configuration, e.IncludeStaff);
            }
            catch (Exception exc)
            {
                this.ProcessModuleLoadException(exc);
            }
        }
    }
}
