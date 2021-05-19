using System;
using System.ComponentModel.DataAnnotations;
using WeLearn.Data.Models.Base;
using static WeLearn.Data.DataValidation.Material;

namespace WeLearn.Data.Models
{
    public class Material : SoftDeleteable, IMetadataHaveable
    {
        [Required]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(MaxLinkLength)]
        public string Link { get; set; }

        [Display(Name = "Date created")]
        public DateTime DateCreated { get; set; }
    }
}
