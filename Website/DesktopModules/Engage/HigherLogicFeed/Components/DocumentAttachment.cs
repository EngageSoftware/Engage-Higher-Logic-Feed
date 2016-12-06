// <copyright file="DocumentAttachment.cs" company="Engage">
// Engage: Higher Logic Feed
// Copyright (c) 2016
// </copyright>

namespace Engage.Dnn.HigherLogicFeed.HigherLogicFeed.Components
{
    using System;
    using System.Linq;

    /// <summary>The structure of a document attachment from the Higher Logic API.</summary>
    public class DocumentAttachment
    {
        /// <summary>Gets or sets the document attachment key.</summary>
        /// <value>The document attachment key.</value>
        public Guid DocumentAttachmentKey { get; set; }

        /// <summary>Gets or sets the document key.</summary>
        /// <value>The document key.</value>
        public Guid DocumentKey { get; set; }

        /// <summary>Gets or sets the name of the file.</summary>
        /// <value>The name of the file.</value>
        public string FileName { get; set; }

        /// <summary>Gets or sets the uploaded by contact.</summary>
        /// <value>The uploaded by contact.</value>
        public ContactConcise UploadedByContact { get; set; }

        /// <summary>Gets or sets the created on date for the attachment.</summary>
        /// <value>The created on.</value>
        public DateTime CreatedOn { get; set; }

        /// <summary>Gets or sets the file extension.</summary>
        /// <value>The file extension.</value>
        public string FileExtension { get; set; }

        /// <summary>Gets or sets the file size in bytes.</summary>
        /// <value>The file size in bytes.</value>
        public int FileSizeInBytes { get; set; }

        /// <summary>Gets or sets the width.</summary>
        /// <value>The width.</value>
        public int Width { get; set; }

        /// <summary>Gets or sets the height.</summary>
        /// <value>The height.</value>
        public int Height { get; set; }

        /// <summary>Gets or sets the duration seconds.</summary>
        /// <value>The duration seconds.</value>
        public int DurationSeconds { get; set; }

        /// <summary>Gets or sets the download URL.</summary>
        /// <value>The download URL.</value>
        public string DownloadUrl { get; set; }

        /// <summary>Gets or sets the icon URL.</summary>
        /// <value>The icon URL.</value>
        public string IconUrl { get; set; }
    }
}
