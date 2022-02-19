using System.Collections.Generic;

namespace WeLearn.Web.ViewModels.ApplicationUser
{
    public class ProfileListModel
    {
        public IEnumerable<ProfileViewModel> Profiles { get; set; }
    }
}