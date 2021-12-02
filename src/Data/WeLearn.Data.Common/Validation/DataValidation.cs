using System.Collections.Generic;

namespace WeLearn.Data.Common.Validation
{
    public static class DataValidation
    {
        public static class Comment
        {
            public const int MaxContentLength = 1000;
        }

        public static class Video
        {
            public const int MaxNameLength = 250;
            public const int MaxLinkLength = 250;

            public const int MinimumVideoSizeInBytes = 0;

            /// <summary>
            /// Equal to 100 megabytes.
            /// </summary>
            public const int MaximumVideoSizeInBytes = 100_000_000;

            public static readonly HashSet<string> AllowedVideoExtensions = new HashSet<string> { ".mp4", ".webm", ".ogv" };
        }

        public static class Material
        {
            public const int MinimumZipFileSizeInBytes = 0;

            /// <summary>
            /// Equal to 10 megabytes.
            /// </summary>
            public const int MaximumZipFileSizeInBytes = 10_000_000;

            public const int MaxNameLength = 250;

            public const int MaxLinkLength = 250;

            public static readonly HashSet<string> AllowedFileExtensions = new HashSet<string>
            {
                ".mp3",
                ".css", ".html", ".htm",
                ".ods", ".xls", ".xlsx",
                ".fnt", ".fon", ".otf", ".ttf",
                ".key", ".odp", ".pps", ".ppt", ".pptx",
                ".csv", ".dat", ".db", ".dbf", ".log", ".mdb", ".sav", ".sql", ".xml",
                ".doc", ".docx", ".txt", ".odt", ".pdf", ".rtf", ".tex", ".txt", ".wpd",
                ".jpg", ".jpeg", ".gif", ".png", ".bmp", ".ai", ".ico", ".ps", ".psd", ".svg", ".tiff", ".tif",
                ".mp4", ".webm", ".ogv", ".3g2", ".3gp", ".avi", ".flv", ".h256", ".m4v", ".mkv", ".mov", ".mpeg", ".rm", ".wmv",
            };
        }

        public static class Lesson
        {
            public const int MaxNameLength = 250;
            public const int MaxDescriptionLength = 1500;
        }

        public static class Category
        {
            public const int MaxNameLength = 250;
        }

        public static class Report
        {
            public const int MaxSubjectLength = 250;
            public const int MaxDescriptionLength = 2000;
        }

        public static class PrivateMessage
        {
            public const int MaxMessageLength = 1500;
        }
    }
}
