// <copyright file="ViewHigherLogicFeedViewModel.cs" company="Engage">
// Engage: Higher Logic Feed
// Copyright (c) 2016
// </copyright>
namespace Engage.Dnn.HigherLogicFeed
{
    using System.Web;

    /// <summary>The view model for the Higher Logic Feed, to be displayed by <see cref="IViewHigherLogicFeedView"/></summary>
    public class ViewHigherLogicFeedViewModel
    {
        /// <summary>Gets or sets the admin message.</summary>
        public string AdminMessage { get; set; }

        /// <summary>Gets or sets a value indicating whether this instance has records.</summary>
        public bool HasRecords { get; set; }

        /// <summary>Gets or sets the header template.</summary>
        public IHtmlString HeaderTemplate { get; set; }

        /// <summary>Gets or sets the item template.</summary>
        public IHtmlString ItemTemplate { get; set; }

        /// <summary>Gets or sets the footer template.</summary>
        public IHtmlString FooterTemplate { get; set; }

        /// <summary>Gets or sets the no records template.</summary>
        public IHtmlString NoRecordsTemplate { get; set; }
    }
}
