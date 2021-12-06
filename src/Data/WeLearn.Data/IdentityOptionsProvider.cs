using Microsoft.AspNetCore.Identity;

namespace WeLearn.Data
{
    public static class IdentityOptionsProvider
    {
        public static void GetIdentityOptions(IdentityOptions options)
        {
            options.SignIn.RequireConfirmedAccount = false;
            options.Password.RequiredLength = 6;
            options.Password.RequireUppercase = false;
            options.Password.RequireNonAlphanumeric = false;
        }
    }
}
