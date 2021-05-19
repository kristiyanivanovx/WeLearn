using Hangfire.Dashboard;

namespace WeLearn.Web.Infrastructure
{
    public class CustomDashboardAuthorizationFilter : IDashboardAuthorizationFilter
    {
        public bool Authorize(DashboardContext context) => context.GetHttpContext().User.IsInRole("Admin");
    }
}

