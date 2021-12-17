namespace WeLearn.Common
{
    public static class GlobalConstants
    {
        public const string SystemName = "WeLearn";

        public const string ApplicationAdministratorEmail = "welearnbg@gmail.com";

        public const string ApplicationAdministratorUsername = "Admin";

        public const string ApplicationAdministratorRoleName = "Admin";

        public const string ApplicationHeadAdministratorRoleName = "HeadAdmin";

        public const string ApplicationAdministrationAreaName = "Administration";

        public const string ApplicationHostName = "welearn-bg.herokuapp.com";

        public const string ApplicationAdministratorId = "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6";

        // ML data and models
        public const string ModelFile = "WeLearnLessonsModel.zip";
        public const string OutputFileAbove = "../../../WeLearnLessonsModel.zip";

        public const string ExportPathServices = "./data/";
        public const string ExportPath = "../../Web/WeLearn.Web/data/";
        public const string ExportAbovePath = "../../../data/";

        // public const string ExportCsvPath = "data/UsersInLessons.csv";
        public const string ExportCsvPath = "../../Web/WeLearn.Web/data/UsersInLessons.csv";

        public const string Path = ExportPath + ExportCsvPath;
        public const string AbovePath = ExportAbovePath + ExportCsvPath;

        public const string Quote = "\"";
        public const string EscapedQuote = "\"\"";
        public static readonly char[] CharactersThatMustBeQuoted = { ',', '"', '\n', '\r' };
    }
}
