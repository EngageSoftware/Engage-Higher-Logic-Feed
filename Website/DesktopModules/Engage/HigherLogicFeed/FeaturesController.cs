// <copyright file="FeaturesController.cs" company="Engage">
// Engage: Higher Logic Feed
// Copyright (c) 2016
// </copyright>
namespace Engage.Dnn.HigherLogicFeed
{
    using System.Diagnostics.CodeAnalysis;

    using Engage.Annotations;

    /// <summary>Contains basic information about the module and exposes which DNN integration points the module implements</summary>
    [UsedImplicitly]
    [SuppressMessage("Microsoft.Design", "CA1053:StaticHolderTypesShouldNotHaveConstructors", Justification = "DNN instantiates this class via reflection, so it needs an accessible constructor")]
    public class FeaturesController
    {
        /// <summary>The prefix to use for settings names</summary>
        public const string SettingsPrefix = "Engage_Higher_Logic_Feed_";

        /// <summary>The cache key prefix.</summary>
        public const string CachePrefix = "Engage_Higher_Logic_Feed_Cache_";

        /// <summary>The higher logic API prefix</summary>
        public const string HigherLogicApiPrefix = "https://api.connectedcommunity.org/api/v2.0/";
    }
}
