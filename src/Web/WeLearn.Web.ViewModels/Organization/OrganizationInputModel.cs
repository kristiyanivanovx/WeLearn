using System.ComponentModel.DataAnnotations;
using WeLearn.Services.Mapping;

namespace WeLearn.Web.ViewModels.Organization
{
    public class OrganizationInputModel : IMapTo<Data.Models.User.Organization>, IMapFrom<Data.Models.User.Organization>
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
    }
}