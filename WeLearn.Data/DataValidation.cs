namespace WeLearn.Data
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
        }

        public static class Material
        {
            public const int MaxNameLength = 250;
            public const int MaxLinkLength = 250;
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
    }
}
