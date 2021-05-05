using System;
using WeLearn.Data.Models.Interfaces;
using WeLearn.Data.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace WeLearn.Data.Models
{
    public class Lesson :  SoftDeleteable, IMetadataHaveable
    {
        [Required]
        [MaxLength(250)]
        public string Name { get; set; }

        [Required]
        [MaxLength(1500)]
        public string Description { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public Grade Grade { get; set; }

        public string ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public int VideoId { get; set; }

        public Video Video { get; set; }

        public int MaterialId { get; set; }

        public Material Material { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime? DateDeleted { get; set; }
    }
}
