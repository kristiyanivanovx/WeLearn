using WeLearn.Services.Mapping;

namespace WeLearn.Web.ViewModels.ApplicationUser
{
    public class UserViewModel : IMapFrom<Data.Models.Identity.ApplicationUser>
    {
        public string Id { get; set; }

        public string UserName { get; set; }
    }
}
