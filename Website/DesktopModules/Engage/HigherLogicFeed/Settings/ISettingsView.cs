// <copyright file="ISettingsView.cs" company="Engage">
// Engage: Higher Logic Feed
// Copyright (c) 2016
// </copyright>
namespace Engage.Dnn.HigherLogicFeed
{
    using System;

    using DotNetNuke.UI.Modules;
    using DotNetNuke.Web.Mvp;

    /// <summary>The contract of the Settings view</summary>
    public interface ISettingsView : IModuleView<SettingsViewModel>
    {
        /// <summary>Occurs when <see cref="ISettingsControl.LoadSettings"/> is called.</summary>
        event EventHandler<EventArgs> LoadingSettings;

        /// <summary>Occurs when <see cref="ISettingsControl.UpdateSettings"/> is called.</summary>
        event EventHandler<UpdatingSettingsEventArgs> UpdatingSettings;
    }
}
