// <copyright file="ContactConcise.cs" company="Engage">
// Engage: Higher Logic Feed
// Copyright (c) 2016
// </copyright>

namespace Engage.Dnn.HigherLogicFeed.HigherLogicFeed.Components
{
    using System;
    using System.Linq;

    public class ContactConcise
    {
        public string LinkToProfile { get; set; }
        public string PictureUrl { get; set; }
        public Guid ContactKey { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DisplayName { get; set; }
        public string EmailAddress { get; set; }
        public string CompanyName { get; set; }
        public string CompanyTitle { get; set; }
        public string Designation { get; set; }
        public string MiddleName { get; set; }
    }
}
