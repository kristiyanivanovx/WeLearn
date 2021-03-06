using System.Collections.Generic;

namespace WeLearn.Web.ViewModels.Admin
{
    public class AdministrationIndexViewModel
    {
        public IEnumerable<string> RoleNames { get; set; }

        public int UsersCount { get; set; }

        public int CategoriesCount { get; set; }

        public int LessonsCount { get; set; }

        public int ReportsCount { get; set; }

        public int QuizzesCount { get; set; }
    }
}
