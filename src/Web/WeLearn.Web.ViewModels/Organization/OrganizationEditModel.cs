using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WeLearn.Services.Mapping;
using WeLearn.Web.ViewModels.ApplicationUser;

namespace WeLearn.Web.ViewModels.Organization
{
    public class OrganizationEditModel : IMapFrom<Data.Models.User.Organization>
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Display(Name = "Is deleted")]
        public bool IsDeleted { get; set; }

        public string CreatorId { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}