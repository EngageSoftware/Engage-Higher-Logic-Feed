// <copyright file="DocumentAttachment.cs" company="Engage">
// Engage: Higher Logic Feed
// Copyright (c) 2016
// </copyright>

namespace Engage.Dnn.HigherLogicFeed.HigherLogicFeed.Components
{
    using System;
    using System.Linq;

    public class DocumentAttachment
    {
        public Guid DocumentAttachmentKey { get; set; }

        public Guid DocumentKey { get; set; }

        public string FileName { get; set; }

        public ContactConcise UploadedByContact { get; set; }

        public DateTime CreatedOn { get; set; }

        public string FileExtension { get; set; }

        public int FileSizeInBytes { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public int DurationSeconds { get; set; }

        public string DownloadUrl { get; set; }

        public string IconUrl { get; set; }
    }
}
