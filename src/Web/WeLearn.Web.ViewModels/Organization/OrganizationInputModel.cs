using System.ComponentModel.DataAnnotations;

namespace WeLearn.Web.ViewModels.Organization
{
    public class OrganizationInputModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
