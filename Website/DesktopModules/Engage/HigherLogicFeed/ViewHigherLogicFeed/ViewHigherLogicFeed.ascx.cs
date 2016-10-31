// <copyright file="ViewHigherLogicFeed.ascx.cs" company="Engage">
// Engage: Higher Logic Feed
// Copyright (c) 2016
// </copyright>
namespace Engage.Dnn.HigherLogicFeed
{
    using DotNetNuke.Web.Mvp;

    using WebFormsMvp;

    /// <summary>Displays Higher Logic Feed.</summary>
    [PresenterBinding(typeof(ViewHigherLogicFeedPresenter))]
    public partial class ViewHigherLogicFeed : ModuleView<ViewHigherLogicFeedViewModel>, IViewHigherLogicFeedView
    {
    }
}
