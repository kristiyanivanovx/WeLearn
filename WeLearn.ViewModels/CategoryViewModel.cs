using System;
using System.ComponentModel.DataAnnotations;
using static WeLearn.Data.DataValidation.Category;

namespace WeLearn.ViewModels
{
    public class CategoryViewModel
    {
        public int CategoryId { get; set; }

        [Required]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; }

        [Display(Name = "Date created")]
        public DateTime DateCreated { get; set; }

        [Display(Name = "Is deleted")]
        public bool IsDeleted { get; set; }
    }
}
