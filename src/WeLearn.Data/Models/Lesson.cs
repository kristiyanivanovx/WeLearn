using System;
using WeLearn.Data.Models.Base;
using WeLearn.Data.Models.Enums;
using System.ComponentModel.DataAnnotations;
using static WeLearn.Data.DataValidation.Lesson;

namespace WeLearn.Data.Models
{
    public class Lesson :  SoftDeleteable, IMetadataHaveable
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

        [Display(Name = "Date created")]
        public DateTime DateCreated { get; set; }
    }
}
