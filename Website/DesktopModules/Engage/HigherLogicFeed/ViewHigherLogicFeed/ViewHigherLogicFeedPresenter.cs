// <copyright file="ViewHigherLogicFeedPresenter.cs" company="Engage">
// Engage: Higher Logic Feed
// Copyright (c) 2016
// </copyright>
namespace Engage.Dnn.HigherLogicFeed
{
    using System;
    using System.Globalization;

    using DotNetNuke.Services.Localization;
    using DotNetNuke.Web.Mvp;

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

        /// <summary>Handles the <see cref="IModuleViewBase.Initialize"/> event of the <see cref="Presenter{TView}.View"/>.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void View_Initialize(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception exc)
            {
                this.ProcessModuleLoadException(exc);
            }
        }
    }
}
