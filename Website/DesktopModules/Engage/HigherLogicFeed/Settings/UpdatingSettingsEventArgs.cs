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
        /// <summary>Initializes a new instance of the <see cref="UpdatingSettingsEventArgs"/> class.</summary>
        public UpdatingSettingsEventArgs()
        {
        }
    }
}
