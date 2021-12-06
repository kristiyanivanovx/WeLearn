using System;
using System.ComponentModel.DataAnnotations;

using WeLearn.Data.Models;
using WeLearn.Services.Mapping;

namespace WeLearn.Web.ViewModels.Admin.User
{
    public class AdminUserDeleteModel : IMapFrom<ApplicationUser>
    {
        public string Id { get; set; }

        public string Email { get; set; }

        public string UserName { get; set; }

        public bool IsAdministrator { get; set; }

        [Display(Name = "Date created")]
        public DateTime CreatedOn { get; set; }
    }
}
