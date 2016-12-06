// <copyright file="ViewHigherLogicFeed.ascx.cs" company="Engage">
// Engage: Higher Logic Feed
// Copyright (c) 2016
// </copyright>
namespace Engage.Dnn.HigherLogicFeed
{
    using System;

    using DotNetNuke.UI.Skins;
    using DotNetNuke.UI.Skins.Controls;
    using DotNetNuke.Web.Mvp;

    using WebFormsMvp;

    /// <summary>Displays Higher Logic Feed.</summary>
    [PresenterBinding(typeof(ViewHigherLogicFeedPresenter))]
    public partial class ViewHigherLogicFeed : ModuleView<ViewHigherLogicFeedViewModel>, IViewHigherLogicFeedView
    {
        /// <summary>Raises the <see cref="E:System.Web.UI.Control.Load" /> event.</summary>
        /// <param name="e">The <see cref="T:System.EventArgs" /> object that contains the event data.</param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DotNetNuke.Common.Globals.IsEditMode() && !string.IsNullOrEmpty(this.Model.AdminMessage))
            {
                Skin.AddModuleMessage(this, string.Empty, this.Model.AdminMessage, ModuleMessage.ModuleMessageType.YellowWarning);
            }
        }
    }
}
