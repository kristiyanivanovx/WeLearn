using System.ComponentModel.DataAnnotations;
using WeLearn.Services.Mapping;

namespace WeLearn.Web.ViewModels.ApplicationUser
{
    public class ApplicationUserViewModel : IMapFrom<Data.Models.Identity.ApplicationUser>
    {
        public string Id { get; set; }

        public string UserName { get; set; }
    }
}
