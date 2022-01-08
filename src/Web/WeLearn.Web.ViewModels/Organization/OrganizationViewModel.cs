using System;
using System.Collections;
using System.Collections.Generic;
using WeLearn.Data.Models.Identity;
using WeLearn.Services.Mapping;
using WeLearn.Web.ViewModels.ApplicationUser;

namespace WeLearn.Web.ViewModels.Organization
{
    public class OrganizationViewModel : IMapFrom<Data.Models.User.Organization>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        
        public DateTime CreatedOn { get; set; }

        public int ApplicationUsersCount { get; set; }

        public ICollection<ApplicationUserViewModel> ApplicationUsers { get; set; }
    }
}