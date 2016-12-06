// <copyright file="ContactConcise.cs" company="Engage">
// Engage: Higher Logic Feed
// Copyright (c) 2016
// </copyright>

namespace Engage.Dnn.HigherLogicFeed.HigherLogicFeed.Components
{
    using System;
    using System.Linq;

    /// <summary>Defines the structure of a contact from the Higher Logic API.</summary>
    public class ContactConcise
    {
        /// <summary>Gets or sets the link to profile.</summary>
        /// <value>The link to profile.</value>
        public string LinkToProfile { get; set; }

        /// <summary>Gets or sets the picture URL.</summary>
        /// <value>The picture URL.</value>
        public string PictureUrl { get; set; }

        /// <summary>Gets or sets the contact key.</summary>
        /// <value>The contact key.</value>
        public Guid ContactKey { get; set; }

        /// <summary>Gets or sets the first name.</summary>
        /// <value>The first name.</value>
        public string FirstName { get; set; }

        /// <summary>Gets or sets the last name.</summary>
        /// <value>The last name.</value>
        public string LastName { get; set; }

        /// <summary>Gets or sets the display name.</summary>
        /// <value>The display name.</value>
        public string DisplayName { get; set; }

        /// <summary>Gets or sets the email address.</summary>
        /// <value>The email address.</value>
        public string EmailAddress { get; set; }

        /// <summary>Gets or sets the name of the company.</summary>
        /// <value>The name of the company.</value>
        public string CompanyName { get; set; }

        /// <summary>Gets or sets the company title.</summary>
        /// <value>The company title.</value>
        public string CompanyTitle { get; set; }

        /// <summary>Gets or sets the designation.</summary>
        /// <value>The designation.</value>
        public string Designation { get; set; }

        /// <summary>Gets or sets the name of the middle.</summary>
        /// <value>The name of the middle.</value>
        public string MiddleName { get; set; }
    }
}
