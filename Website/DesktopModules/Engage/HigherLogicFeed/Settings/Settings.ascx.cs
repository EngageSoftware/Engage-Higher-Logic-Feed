// <copyright file="Settings.ascx.cs" company="Engage">
// Engage: Higher Logic Feed
// Copyright (c) 2016
// </copyright>
namespace Engage.Dnn.HigherLogicFeed
{
    using System;

    using DotNetNuke.UI.Modules;
    using DotNetNuke.Web.Mvp;

    using WebFormsMvp;

    /// <summary>Displays the module's settings</summary>
    [PresenterBinding(typeof(SettingsPresenter))]
    public partial class Settings : ModuleView<SettingsViewModel>, ISettingsView, ISettingsControl
    {
        /// <summary>Occurs when <see cref="ISettingsControl.LoadSettings"/> is called.</summary>
        public event EventHandler<EventArgs> LoadingSettings;

        /// <summary>Occurs when <see cref="ISettingsControl.UpdateSettings"/> is called.</summary>
        public event EventHandler<UpdatingSettingsEventArgs> UpdatingSettings;

        /// <summary>Loads the settings.</summary>
        public void LoadSettings()
        {
            this.LoadingSettings?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>Updates the settings.</summary>
        public void UpdateSettings()
        {
            this.UpdatingSettings?.Invoke(
                this,
                new UpdatingSettingsEventArgs(this.HLUserNameTxt.Text, this.HLPasswordTxt.Text, this.HLIAMKeyTxt.Text, this.DiscussionKeyTxt.Text, Convert.ToInt32(this.MaxToRetrieveTxt.Text), this.IncludeStaffChk.Checked, this.DateFormatTxt.Text, this.HeaderTemplateTxt.Text, this.ItemTemplateTxt.Text, this.FooterTemplateTxt.Text, this.NoRecordsTemplateTxt.Text, this.AttachmentItemTemplateTxt.Text, Convert.ToInt32(this.MaxContentLengthTxt.Text), Convert.ToInt32(this.MaxSubjectLengthTxt.Text)));
        }
    }
}
