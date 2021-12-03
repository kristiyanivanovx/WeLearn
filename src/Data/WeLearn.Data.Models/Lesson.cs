using System;
using System.ComponentModel.DataAnnotations;
using WeLearn.Data.Common.Models;
using WeLearn.Data.Models.Enums;

using static WeLearn.Data.Common.Validation.DataValidation.Lesson;

namespace WeLearn.Data.Models
{
    public class Lesson : BaseDeletableModel<int>
    {
        [Required]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(MaxDescriptionLength)]
        public string Description { get; set; }

        [Display(Name = "Is approved")]
        public bool IsApproved { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public Grade Grade { get; set; }

        public string ApplicationUserId { get; set; }

        [Display(Name = "User")]
        public ApplicationUser ApplicationUser { get; set; }

        public int VideoId { get; set; }

        public Video Video { get; set; }

        public int MaterialId { get; set; }

        public Material Material { get; set; }

        // [Display(Name = "Date created")]
        // public DateTime DateCreated { get; set; }
    }
}
