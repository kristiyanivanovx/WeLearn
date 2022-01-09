using System;
using System.Collections.Generic;
using WeLearn.Services.Mapping;
using WeLearn.Web.ViewModels.ApplicationUser;

namespace WeLearn.Web.ViewModels.Organization
{
    public class OrganizationViewModel : IMapFrom<Data.Models.User.Organization>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        
        public bool IsDeleted { get; set; }

        public DateTime CreatedOn { get; set; }

        public int ApplicationUsersCount { get; set; }
        
        public string CreatorId { get; set; }

        public string CreatorUserName { get; set; }

        public ICollection<ApplicationUserViewModel> ApplicationUsers { get; set; }
    }
}