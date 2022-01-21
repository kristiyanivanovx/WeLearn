namespace WeLearn.Common
{
    public static class GlobalConstants
    {
        public const string SystemName = "WeLearn";

        public const string ApplicationAdministrationAreaName = "Administration";

        // Head Administrator
        public const string ApplicationHeadAdministratorEmail = "welearnbg@gmail.com";

        public const string ApplicationHeadAdministratorUsername = "HeadAdmin";

        public const string ApplicationHeadAdministratorRoleName = "HeadAdmin";

        public const string ApplicationHeadAdministratorId = "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6";

        // Regular Administrator
        public const string ApplicationRegularAdministratorEmail = "default@gmail.com";

        public const string ApplicationRegularAdministratorUsername = "RegularAdmin";

        public const string ApplicationRegularAdministratorRoleName = "Admin";

        public const string ApplicationRegularAdministratorId = "d91316c6-8823-4614-a3c5-6228f06c746a";

        // Teacher User
        public const string ApplicationTeacherEmail = "peter.856@gmail.com";

        public const string ApplicationTeacherUsername = "Peter85";

        public const string ApplicationTeacherRoleName = "Teacher";

        public const string ApplicationTeacherId = "3d6b0f85-4c05-4d82-8a3b-08c81974c9fc";

        // Other
        public const string ApplicationHostName = "welearn-bg.herokuapp.com";

        public const string ModelFile = "WeLearnLessonsModel.zip";

        public const string ExportDirectory = "Data";

        public const string ExportFileName = "UsersInLessons.csv";

        public const string Quote = "\"";

        public const string EscapedQuote = "\"\"";

        public static readonly char[] CharactersThatMustBeQuoted = { ',', '"', '\n', '\r' };
    }
}
