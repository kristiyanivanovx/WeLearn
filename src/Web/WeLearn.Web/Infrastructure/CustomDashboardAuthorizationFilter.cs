using Hangfire.Dashboard;

using static WeLearn.Common.GlobalConstants;

namespace WeLearn.Web.Infrastructure
{
    public class CustomDashboardAuthorizationFilter : IDashboardAuthorizationFilter
    {
        public bool Authorize(DashboardContext context)
            => context.GetHttpContext().User.IsInRole(SystemRegularAdministratorRoleName);
    }
}
