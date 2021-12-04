using System;
using System.ComponentModel.DataAnnotations;
using WeLearn.Services.Mapping;
using static WeLearn.Data.Common.Validation.DataValidation.Category;

namespace WeLearn.Web.ViewModels.Category
{
    public class CategoryViewModel : IMapFrom<Data.Models.Category>, IMapTo<Data.Models.Category>
    {
        public int CategoryId { get; set; }

        public int Id { get; set; }

        [Required]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; }

        [Display(Name = "Date created")]
        public DateTime CreatedOn { get; set; }

        [Display(Name = "Is deleted")]
        public bool IsDeleted { get; set; }
    }
}
